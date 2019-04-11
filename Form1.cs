using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrizesEsparsas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MatrizLigada matriz1, matriz2, matriz3;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Limpar()
        {
            txtColuna1.Clear();
            txtColuna2.Clear();
            txtLinha1.Clear();
            txtLinha2.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
        }

        private void btnExcluirMatriz1_Click(object sender, EventArgs e)
        {
            matriz1.Excluir();
            matriz1.Exibir(dgvMatriz1);
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha1.Text);
            int coluna = int.Parse(txtColuna1.Text);

            MessageBox.Show("O valor nas coordenadas (" + linha + "," + coluna + ") é " + matriz1.ValorDe(linha, coluna).ToString());
            txtValor1.Text = matriz1.ValorDe(linha, coluna).ToString();
        }

        private void btnExcluir1_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha1.Text);
            int coluna = int.Parse(txtColuna1.Text);

            matriz1.RemoverEm(linha, coluna);
            matriz1.Exibir(dgvMatriz1);
        }

        private void btnCriar2_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha2.Text);
            int coluna = int.Parse(txtColuna2.Text);
            matriz2 = new MatrizLigada(linha, coluna);

            matriz2.Exibir(dgvMatriz2);

            Limpar();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha2.Text);
            int coluna = int.Parse(txtColuna2.Text);

            MessageBox.Show("O valor nas coordenadas (" + linha + "," + coluna + ") é " + matriz2.ValorDe(linha, coluna).ToString());
            txtValor2.Text = matriz2.ValorDe(linha, coluna).ToString();
        }

        private void btnIncluir2_Click(object sender, EventArgs e)
        {
            if (matriz2 != null)
            {

                int linha = int.Parse(txtLinha2.Text);
                int coluna = int.Parse(txtColuna2.Text);
                double valor = double.Parse(txtValor2.Text);

                matriz2.Inserir(valor, linha, coluna);
                matriz2.Exibir(dgvMatriz2);

                txtValor2.Clear();
                txtColuna2.Clear();
                txtLinha2.Clear();
            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha2.Text);
            int coluna = int.Parse(txtColuna2.Text);

            matriz2.RemoverEm(linha, coluna);
            matriz2.Exibir(dgvMatriz2);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            matriz3 = matriz1.SomarMatrizes(matriz2);
            matriz3.Exibir(dgvIntersseccao);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            matriz3 = matriz1.MultiplicarMatrizes(matriz2);
            matriz3.Exibir(dgvIntersseccao);
        }

        private void btnExcluirMatriz2_Click(object sender, EventArgs e)
        {
            matriz2.Excluir();
            matriz2.Exibir(dgvMatriz2);
        }

        private void btnExcluirMatriz3_Click(object sender, EventArgs e)
        {
            matriz3.Excluir();
            matriz3.Exibir(dgvIntersseccao);
        }

        
        private void btnSomarColuna1_Click(object sender, EventArgs e)
        {
            int coluna = int.Parse(txtColuna1.Text);
            double valor = double.Parse(txtValor1.Text);
            matriz1.SomarNaColuna(valor,coluna);
            matriz1.Exibir(dgvMatriz1);
        }

        private void btnSomarColuna2_Click(object sender, EventArgs e)
        {
            int coluna = int.Parse(txtColuna2.Text);
            double valor = double.Parse(txtValor2.Text);
            matriz2.SomarNaColuna(valor, coluna);
            matriz2.Exibir(dgvMatriz2);
        }

        private void btnLer2_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arq = new StreamReader(dlgAbrir.FileName);



                while (!arq.EndOfStream)
                {
                    string linhaArquivo = arq.ReadLine();
                    string[] celula = linhaArquivo.Split(' ');

                    double valor = double.Parse(celula[0]);
                    int linha = int.Parse(celula[1]);
                    int coluna = int.Parse(celula[2]);

                    matriz2.Inserir(valor, linha, coluna);
                }
                matriz2.Exibir(dgvMatriz2);
                arq.Close();
            }
        }

        private void btnLer1_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arq = new StreamReader(dlgAbrir.FileName);

                

                while (!arq.EndOfStream)
                {
                    string linhaArquivo = arq.ReadLine();
                    string[] celula = linhaArquivo.Split(' ');

                    double valor = double.Parse(celula[0]);
                    int linha = int.Parse(celula[1]);
                    int coluna = int.Parse(celula[2]);

                    matriz1.Inserir(valor, linha, coluna);
                }
                matriz1.Exibir(dgvMatriz1);
                arq.Close();
            }
        }

        private void btnIncluir1_Click(object sender, EventArgs e)
        {
            if (matriz1 != null)
            {

                int linha = int.Parse(txtLinha1.Text);
                int coluna = int.Parse(txtColuna1.Text);
                double valor = double.Parse(txtValor1.Text);

                matriz1.Inserir(valor, linha, coluna);
                matriz1.Exibir(dgvMatriz1);

                txtValor1.Clear();
                txtColuna1.Clear();
                txtLinha1.Clear();
            }
            
        }

        private void btnCriar1_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(txtLinha1.Text);
            int coluna = int.Parse(txtColuna1.Text);
            matriz1 = new MatrizLigada(linha, coluna);

            matriz1.Exibir(dgvMatriz1);
            
            txtColuna1.Clear();
            txtLinha1.Clear();
        }

       
    }
}
