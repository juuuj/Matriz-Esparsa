using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizesEsparsas
{
    class MatrizLigada
    {
        int rows, columns;
        Celula matriz;
       
        public int Rows
        {
            get { return rows; }
        }   
        public int Columns
        {
            get { return columns; }
        }
  
        
        public MatrizLigada(int linhas, int colunas)
        {
            if (linhas <= 0 || colunas <= 0)
                throw new Exception("As colunas e linhas devem ser maiores que 0");

            this.rows = linhas;
            this.columns = colunas;

            matriz = new Celula(null, -1, -1);
            
            Celula aux = matriz;

            for (int i = 0; i < linhas; i++)
            {
                Celula linhaCabeca = new Celula(null, i, -1);

                aux.Abaixo = linhaCabeca;
                aux.Direita = aux;
                aux = aux.Abaixo;
            }
            aux.Abaixo = matriz;
            aux.Direita = aux;

            aux = matriz;

            for (int i = 0; i < colunas; i++)
            {
                Celula colunaMatriz = new Celula(null, -1, i);
                
                if (aux != matriz)
                    aux.Abaixo = aux;

                aux.Direita = colunaMatriz;
                aux = aux.Direita;
            }
            aux.Abaixo = aux;
            aux.Direita = matriz;
        }
        
        public void Inserir(double valor, int linha, int coluna)
        {
            if (linha < 0 || linha >= this.Rows ||
                coluna < 0 || coluna >= this.Columns)
                throw new Exception("Linha e/ou coluna fora dos limites. ");

        
            if (valor == 0)
                throw new Exception("O valor inserido não pode ser 0.");

            Celula colunaMatriz = matriz;
            Celula linhaMatriz = matriz;

            for (int j = 0; j <= coluna; j++)
                colunaMatriz = colunaMatriz.Direita;

            for (int i = 0; i <= linha; i++)
                linhaMatriz = linhaMatriz.Abaixo;

            Celula anterior = linhaMatriz;
            Celula atual = linhaMatriz.Direita;

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual = atual.Direita;
            }

            if (ValorDe(linha, coluna) == 0)
            {

                Celula insercao = new Celula(valor, linha, coluna);

                anterior.Direita = insercao;
                insercao.Direita = atual;

                Celula colunaAnterior = colunaMatriz;
                Celula percursoColuna = colunaMatriz.Abaixo;

                while (percursoColuna.Abaixo != colunaMatriz && percursoColuna.Linha < linha)
                {
                    colunaAnterior = percursoColuna;
                    percursoColuna = percursoColuna.Abaixo;
                }
                insercao.Abaixo = percursoColuna;
                colunaAnterior.Abaixo = insercao;
            }
            else
                atual.Valor = valor; 
        }
       
        public double ValorDe(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 ||
                linha >= Rows || coluna >= Columns)
                throw new Exception("Linha ou coluna estão foras do dos limites.");

            Celula linhaMatriz = matriz;

            for (int i = 0; i <= linha; i++)
                linhaMatriz = linhaMatriz.Abaixo;
            
            Celula auxColuna = linhaMatriz.Direita;

            while (auxColuna.Coluna < coluna && auxColuna.Direita != linhaMatriz)
                auxColuna = auxColuna.Direita;

            if (auxColuna.Coluna != coluna)
                return 0;

            return (double)auxColuna.Valor;
        }

        public bool RemoverEm(int linha, int coluna)
        {
            if (linha < 0 || linha >= Rows ||
                coluna < 0 || coluna >= Columns)
                throw new Exception("Linha ou Coluna fora dos limites");

            if (ValorDe(linha, coluna) == 0)
                return false; 

            Celula colunaMatriz = matriz;
            Celula linhaMatriz = matriz;

            for (int j = 0; j <= coluna; j++)
                colunaMatriz = colunaMatriz.Direita;

            for (int i = 0; i <= linha; i++)
                linhaMatriz = linhaMatriz.Abaixo;

            Celula anterior = linhaMatriz;
            Celula atual = linhaMatriz.Direita; 

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual = atual.Direita;
            }

            anterior.Direita = atual.Direita;
            
            Celula auxColuna = colunaMatriz;

            while (auxColuna.Abaixo != atual)
                auxColuna = auxColuna.Abaixo;

            auxColuna.Abaixo = atual.Abaixo;

            return true;
        }
        
        public void SomarNaColuna(double k, int coluna)
        {
            if (coluna < 0 || coluna >= Columns)
                throw new Exception("Coluna menor que 0 ou fora dos limites.");

            if (k == 0)
                throw new Exception("O valor deve ser diferente de 0.");

            double valor = 0;
            for (int i = 0; i < Rows; i++)
            {
                valor = ValorDe(i, coluna);
                if (valor + k == 0)
                {
                    RemoverEm(i, coluna);
                    continue;
                }
                Inserir(valor + k, i, coluna);
            }
        }
        
        public void Exibir(DataGridView gridView)
        {

            if (gridView == null)
                throw new Exception("gridView utilizado é nulo.");

            gridView.Columns.Clear();
            gridView.Rows.Clear();

            for (int i = 0; i < this.Columns; i++)
                gridView.Columns.Add(i.ToString(), i.ToString());

            string[] linhaMatriz = new string[this.Columns];
            
            for (int j = 0; j < this.Rows; j++)
            {
                for (int k = 0; k < this.Columns; k++)
                {
                    linhaMatriz[k] = this.ValorDe(j, k).ToString();
                }
                gridView.Rows.Add(linhaMatriz);
                gridView.Rows[j].HeaderCell.Value = j.ToString(); 
            }
            gridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            gridView.AutoResizeColumns();
        }
        
        public void Excluir()
        {
            matriz = null;
            rows = 0;
            columns = 0;
        }
        
        public MatrizLigada SomarMatrizes(MatrizLigada outraMatriz)
        {
            if (this.rows != outraMatriz.rows || this.columns != outraMatriz.columns)
                throw new Exception("As Matrizes dever ter a mesma dimensão!");

            MatrizLigada soma = new MatrizLigada(this.rows, this.columns);

            Celula atual = this.matriz.Abaixo.Direita;
            
            for (int l = 0; l < this.rows; l++)
            {
                for (int c = atual.Coluna; c >= 0; c = atual.Coluna)
                {
                    if (atual.Valor != null)
                    {
                        atual = atual.Direita;
                        soma.Inserir(this.ValorDe(l, c), l, c);
                    }
                }
                atual = atual.Abaixo.Direita;
            }

            atual = outraMatriz.matriz.Abaixo.Direita;

            for (int l = 0; l < outraMatriz.rows; l++)
            {
                for (int c = atual.Coluna; c >= 0; c = atual.Coluna)
                    if (atual.Valor != null)
                    {
                        double elem = soma.ValorDe(l, c) != 0 ? soma.ValorDe(l, c) + outraMatriz.ValorDe(l, c)
                                                                : outraMatriz.ValorDe(l, c);

                        soma.Inserir(elem, l, c);
                        atual = atual.Direita;
                    }
                atual = atual.Abaixo.Direita;
            }

            return soma;
        }
        
        public MatrizLigada MultiplicarMatrizes(MatrizLigada outraMatriz)
        {
            if (this.Columns != outraMatriz.Rows)
                throw new Exception("Número de colunas de uma matriz deve ser igual o número de linhas da outra");

            MatrizLigada ret;

            ret = new MatrizLigada(this.Rows, outraMatriz.Columns);


            double total = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < outraMatriz.Columns; j++)
                {
                    total = 0;
                    int k;
                    for (k = 0; k < this.Columns; k++)
                    {
                        total += this.ValorDe(i, k) * outraMatriz.ValorDe(k, j);
                    }
                    if (total != 0)
                    {
                        ret.Inserir(total, i, j);
                    }
                }
            }

            return ret;
        }
       
        public override string ToString()
        {
            String ret = "( ";

            Celula linhaCabeca = matriz.Abaixo;

            while (linhaCabeca != matriz)
            {
                Celula percursoLinha = linhaCabeca.Direita;

                while (percursoLinha != linhaCabeca)
                {
                    ret += percursoLinha.ToString() + (percursoLinha.Direita != linhaCabeca ? ", " : " ");

                    percursoLinha = percursoLinha.Direita;
                }

                linhaCabeca = linhaCabeca.Abaixo;
            }
            return ret + ")";
        }


    }
}
