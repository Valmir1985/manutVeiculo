namespace manutVeiculo
{
    partial class ConsultaTrocas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKmAtual = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGViewConsultaTrocas = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.columnPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewConsultaTrocas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAno);
            this.groupBox1.Controls.Add(this.lbAno);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKmAtual);
            this.groupBox1.Controls.Add(this.cmbModelo);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2010",
            "2011",
            "2012",
            "2013"});
            this.cmbAno.Location = new System.Drawing.Point(404, 55);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(135, 21);
            this.cmbAno.TabIndex = 25;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(401, 40);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 13);
            this.lbAno.TabIndex = 24;
            this.lbAno.Text = "Ano";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(483, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 35);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(211, 100);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 35);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Km Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Marca";
            // 
            // txtKmAtual
            // 
            this.txtKmAtual.Location = new System.Drawing.Point(582, 56);
            this.txtKmAtual.Name = "txtKmAtual";
            this.txtKmAtual.Size = new System.Drawing.Size(145, 20);
            this.txtKmAtual.TabIndex = 17;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "",
            "Celta",
            "Civic",
            "Corola",
            "Corsa",
            "Fiesta",
            "Fox",
            "Fusca",
            "Gol",
            "Hb20",
            "Siena"});
            this.cmbModelo.Location = new System.Drawing.Point(212, 56);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(155, 21);
            this.cmbModelo.TabIndex = 16;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "",
            "Chevrolet",
            "Ford",
            "Fiat",
            "Honda",
            "Renault",
            "Peugeot",
            "Volkswagen"});
            this.cmbMarca.Location = new System.Drawing.Point(21, 56);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(155, 21);
            this.cmbMarca.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGViewConsultaTrocas);
            this.groupBox2.Location = new System.Drawing.Point(26, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 347);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            // 
            // dGViewConsultaTrocas
            // 
            this.dGViewConsultaTrocas.AllowUserToAddRows = false;
            this.dGViewConsultaTrocas.AllowUserToDeleteRows = false;
            this.dGViewConsultaTrocas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewConsultaTrocas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPeca,
            this.columnKm,
            this.columnPreco});
            this.dGViewConsultaTrocas.Location = new System.Drawing.Point(17, 19);
            this.dGViewConsultaTrocas.Name = "dGViewConsultaTrocas";
            this.dGViewConsultaTrocas.ReadOnly = true;
            this.dGViewConsultaTrocas.Size = new System.Drawing.Size(720, 310);
            this.dGViewConsultaTrocas.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Gerar O.S.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // columnPeca
            // 
            this.columnPeca.HeaderText = "Peça";
            this.columnPeca.Name = "columnPeca";
            this.columnPeca.ReadOnly = true;
            this.columnPeca.Width = 238;
            // 
            // columnKm
            // 
            this.columnKm.HeaderText = "Km";
            this.columnKm.Name = "columnKm";
            this.columnKm.ReadOnly = true;
            this.columnKm.Width = 198;
            // 
            // columnPreco
            // 
            this.columnPreco.HeaderText = "Preço";
            this.columnPreco.Name = "columnPreco";
            this.columnPreco.ReadOnly = true;
            this.columnPreco.Width = 240;
            // 
            // ConsultaTrocas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ConsultaTrocas";
            this.Text = "Consulta de Trocas";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewConsultaTrocas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKmAtual;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.DataGridView dGViewConsultaTrocas;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPreco;
    }
}