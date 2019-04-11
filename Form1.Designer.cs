namespace MatrizesEsparsas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.btnCriar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir1 = new System.Windows.Forms.Button();
            this.btnIncluir1 = new System.Windows.Forms.Button();
            this.txtLinha1 = new System.Windows.Forms.TextBox();
            this.txtColuna1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.btnIncluir2 = new System.Windows.Forms.Button();
            this.txtLinha2 = new System.Windows.Forms.TextBox();
            this.txtColuna2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluirMatriz1 = new System.Windows.Forms.Button();
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirMatriz2 = new System.Windows.Forms.Button();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExcluirMatriz3 = new System.Windows.Forms.Button();
            this.dgvIntersseccao = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSomarColuna2 = new System.Windows.Forms.Button();
            this.btnSomarColuna1 = new System.Windows.Forms.Button();
            this.btnLer1 = new System.Windows.Forms.Button();
            this.btnLer2 = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntersseccao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Controls.Add(this.btnBuscar1);
            this.groupBox1.Controls.Add(this.btnCriar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExcluir1);
            this.groupBox1.Controls.Add(this.btnIncluir1);
            this.groupBox1.Controls.Add(this.txtLinha1);
            this.groupBox1.Controls.Add(this.txtColuna1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(58, 80);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(108, 20);
            this.txtValor1.TabIndex = 8;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(91, 106);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar1.TabIndex = 7;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // btnCriar1
            // 
            this.btnCriar1.Location = new System.Drawing.Point(10, 106);
            this.btnCriar1.Name = "btnCriar1";
            this.btnCriar1.Size = new System.Drawing.Size(75, 23);
            this.btnCriar1.TabIndex = 6;
            this.btnCriar1.Text = "Criar";
            this.btnCriar1.UseVisualStyleBackColor = true;
            this.btnCriar1.Click += new System.EventHandler(this.btnCriar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Linha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coluna:";
            // 
            // btnExcluir1
            // 
            this.btnExcluir1.Location = new System.Drawing.Point(91, 137);
            this.btnExcluir1.Name = "btnExcluir1";
            this.btnExcluir1.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir1.TabIndex = 3;
            this.btnExcluir1.Text = "Excluir";
            this.btnExcluir1.UseVisualStyleBackColor = true;
            this.btnExcluir1.Click += new System.EventHandler(this.btnExcluir1_Click);
            // 
            // btnIncluir1
            // 
            this.btnIncluir1.Location = new System.Drawing.Point(10, 137);
            this.btnIncluir1.Name = "btnIncluir1";
            this.btnIncluir1.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir1.TabIndex = 2;
            this.btnIncluir1.Text = "Incluir";
            this.btnIncluir1.UseVisualStyleBackColor = true;
            this.btnIncluir1.Click += new System.EventHandler(this.btnIncluir1_Click);
            // 
            // txtLinha1
            // 
            this.txtLinha1.Location = new System.Drawing.Point(58, 52);
            this.txtLinha1.Name = "txtLinha1";
            this.txtLinha1.Size = new System.Drawing.Size(108, 20);
            this.txtLinha1.TabIndex = 1;
            // 
            // txtColuna1
            // 
            this.txtColuna1.Location = new System.Drawing.Point(58, 25);
            this.txtColuna1.Name = "txtColuna1";
            this.txtColuna1.Size = new System.Drawing.Size(108, 20);
            this.txtColuna1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValor2);
            this.groupBox2.Controls.Add(this.btnBuscar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCriar2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnExcluir2);
            this.groupBox2.Controls.Add(this.btnIncluir2);
            this.groupBox2.Controls.Add(this.txtLinha2);
            this.groupBox2.Controls.Add(this.txtColuna2);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(58, 78);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(108, 20);
            this.txtValor2.TabIndex = 10;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(91, 110);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar2.TabIndex = 9;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Linha:";
            // 
            // btnCriar2
            // 
            this.btnCriar2.Location = new System.Drawing.Point(10, 110);
            this.btnCriar2.Name = "btnCriar2";
            this.btnCriar2.Size = new System.Drawing.Size(75, 23);
            this.btnCriar2.TabIndex = 8;
            this.btnCriar2.Text = "Criar";
            this.btnCriar2.UseVisualStyleBackColor = true;
            this.btnCriar2.Click += new System.EventHandler(this.btnCriar2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coluna:";
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(91, 139);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir2.TabIndex = 3;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // btnIncluir2
            // 
            this.btnIncluir2.Location = new System.Drawing.Point(10, 139);
            this.btnIncluir2.Name = "btnIncluir2";
            this.btnIncluir2.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir2.TabIndex = 2;
            this.btnIncluir2.Text = "Incluir";
            this.btnIncluir2.UseVisualStyleBackColor = true;
            this.btnIncluir2.Click += new System.EventHandler(this.btnIncluir2_Click);
            // 
            // txtLinha2
            // 
            this.txtLinha2.Location = new System.Drawing.Point(58, 52);
            this.txtLinha2.Name = "txtLinha2";
            this.txtLinha2.Size = new System.Drawing.Size(108, 20);
            this.txtLinha2.TabIndex = 1;
            // 
            // txtColuna2
            // 
            this.txtColuna2.Location = new System.Drawing.Point(58, 25);
            this.txtColuna2.Name = "txtColuna2";
            this.txtColuna2.Size = new System.Drawing.Size(108, 20);
            this.txtColuna2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMultiplicar);
            this.groupBox3.Controls.Add(this.btnSomar);
            this.groupBox3.Location = new System.Drawing.Point(12, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 53);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interssecção";
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(91, 22);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(84, 23);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(10, 22);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(211, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 419);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLer1);
            this.tabPage1.Controls.Add(this.btnSomarColuna1);
            this.tabPage1.Controls.Add(this.btnExcluirMatriz1);
            this.tabPage1.Controls.Add(this.dgvMatriz1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMatriz1
            // 
            this.btnExcluirMatriz1.Location = new System.Drawing.Point(370, 364);
            this.btnExcluirMatriz1.Name = "btnExcluirMatriz1";
            this.btnExcluirMatriz1.Size = new System.Drawing.Size(101, 23);
            this.btnExcluirMatriz1.TabIndex = 8;
            this.btnExcluirMatriz1.Text = "Excluir Matriz";
            this.btnExcluirMatriz1.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz1.Click += new System.EventHandler(this.btnExcluirMatriz1_Click);
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AllowUserToAddRows = false;
            this.dgvMatriz1.AllowUserToDeleteRows = false;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.Location = new System.Drawing.Point(17, 15);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.Size = new System.Drawing.Size(454, 343);
            this.dgvMatriz1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLer2);
            this.tabPage2.Controls.Add(this.btnSomarColuna2);
            this.tabPage2.Controls.Add(this.btnExcluirMatriz2);
            this.tabPage2.Controls.Add(this.dgvMatriz2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matriz 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMatriz2
            // 
            this.btnExcluirMatriz2.Location = new System.Drawing.Point(370, 364);
            this.btnExcluirMatriz2.Name = "btnExcluirMatriz2";
            this.btnExcluirMatriz2.Size = new System.Drawing.Size(101, 23);
            this.btnExcluirMatriz2.TabIndex = 9;
            this.btnExcluirMatriz2.Text = "Excluir Matriz";
            this.btnExcluirMatriz2.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz2.Click += new System.EventHandler(this.btnExcluirMatriz2_Click);
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.Location = new System.Drawing.Point(17, 15);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.Size = new System.Drawing.Size(454, 343);
            this.dgvMatriz2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExcluirMatriz3);
            this.tabPage3.Controls.Add(this.dgvIntersseccao);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(496, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Interssecção";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMatriz3
            // 
            this.btnExcluirMatriz3.Location = new System.Drawing.Point(374, 364);
            this.btnExcluirMatriz3.Name = "btnExcluirMatriz3";
            this.btnExcluirMatriz3.Size = new System.Drawing.Size(97, 23);
            this.btnExcluirMatriz3.TabIndex = 10;
            this.btnExcluirMatriz3.Text = "Exluir Matriz";
            this.btnExcluirMatriz3.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz3.Click += new System.EventHandler(this.btnExcluirMatriz3_Click);
            // 
            // dgvIntersseccao
            // 
            this.dgvIntersseccao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntersseccao.Location = new System.Drawing.Point(17, 15);
            this.dgvIntersseccao.Name = "dgvIntersseccao";
            this.dgvIntersseccao.Size = new System.Drawing.Size(454, 343);
            this.dgvIntersseccao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Matrizes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Esparsas";
            // 
            // btnSomarColuna2
            // 
            this.btnSomarColuna2.Location = new System.Drawing.Point(266, 364);
            this.btnSomarColuna2.Name = "btnSomarColuna2";
            this.btnSomarColuna2.Size = new System.Drawing.Size(98, 23);
            this.btnSomarColuna2.TabIndex = 10;
            this.btnSomarColuna2.Text = "Somar Coluna";
            this.btnSomarColuna2.UseVisualStyleBackColor = true;
            this.btnSomarColuna2.Click += new System.EventHandler(this.btnSomarColuna2_Click);
            // 
            // btnSomarColuna1
            // 
            this.btnSomarColuna1.Location = new System.Drawing.Point(266, 364);
            this.btnSomarColuna1.Name = "btnSomarColuna1";
            this.btnSomarColuna1.Size = new System.Drawing.Size(98, 23);
            this.btnSomarColuna1.TabIndex = 11;
            this.btnSomarColuna1.Text = "Somar Coluna";
            this.btnSomarColuna1.UseVisualStyleBackColor = true;
            this.btnSomarColuna1.Click += new System.EventHandler(this.btnSomarColuna1_Click);
            // 
            // btnLer1
            // 
            this.btnLer1.Location = new System.Drawing.Point(17, 364);
            this.btnLer1.Name = "btnLer1";
            this.btnLer1.Size = new System.Drawing.Size(84, 23);
            this.btnLer1.TabIndex = 12;
            this.btnLer1.Text = "Ler Arquivo";
            this.btnLer1.UseVisualStyleBackColor = true;
            this.btnLer1.Click += new System.EventHandler(this.btnLer1_Click);
            // 
            // btnLer2
            // 
            this.btnLer2.Location = new System.Drawing.Point(17, 364);
            this.btnLer2.Name = "btnLer2";
            this.btnLer2.Size = new System.Drawing.Size(84, 23);
            this.btnLer2.TabIndex = 13;
            this.btnLer2.Text = "Ler Arquivo";
            this.btnLer2.UseVisualStyleBackColor = true;
            this.btnLer2.Click += new System.EventHandler(this.btnLer2_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntersseccao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir1;
        private System.Windows.Forms.Button btnIncluir1;
        private System.Windows.Forms.TextBox txtLinha1;
        private System.Windows.Forms.TextBox txtColuna1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.Button btnIncluir2;
        private System.Windows.Forms.TextBox txtLinha2;
        private System.Windows.Forms.TextBox txtColuna2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMatriz2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvIntersseccao;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.Button btnCriar1;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnCriar2;
        private System.Windows.Forms.Button btnExcluirMatriz1;
        private System.Windows.Forms.Button btnExcluirMatriz2;
        private System.Windows.Forms.Button btnExcluirMatriz3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSomarColuna1;
        private System.Windows.Forms.Button btnSomarColuna2;
        private System.Windows.Forms.Button btnLer1;
        private System.Windows.Forms.Button btnLer2;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

