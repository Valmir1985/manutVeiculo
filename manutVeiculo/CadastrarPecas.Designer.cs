namespace manutVeiculo
{
    partial class CadastrarPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPecaServico = new System.Windows.Forms.TextBox();
            this.txtKmTroca = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelPeca = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.panelPeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peça ou Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Km de troca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(31, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(117, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(31, 105);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(117, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtPecaServico
            // 
            this.txtPecaServico.Location = new System.Drawing.Point(200, 37);
            this.txtPecaServico.Name = "txtPecaServico";
            this.txtPecaServico.Size = new System.Drawing.Size(294, 20);
            this.txtPecaServico.TabIndex = 6;
            // 
            // txtKmTroca
            // 
            this.txtKmTroca.Location = new System.Drawing.Point(200, 105);
            this.txtKmTroca.Name = "txtKmTroca";
            this.txtKmTroca.Size = new System.Drawing.Size(130, 20);
            this.txtKmTroca.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(99, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(84, 35);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(372, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelPeca
            // 
            this.panelPeca.Controls.Add(this.txtPreco);
            this.panelPeca.Controls.Add(this.lblPreco);
            this.panelPeca.Controls.Add(this.txtKmTroca);
            this.panelPeca.Controls.Add(this.txtPecaServico);
            this.panelPeca.Controls.Add(this.txtModelo);
            this.panelPeca.Controls.Add(this.txtMarca);
            this.panelPeca.Controls.Add(this.label4);
            this.panelPeca.Controls.Add(this.label3);
            this.panelPeca.Controls.Add(this.label2);
            this.panelPeca.Controls.Add(this.label1);
            this.panelPeca.Location = new System.Drawing.Point(20, 15);
            this.panelPeca.Name = "panelPeca";
            this.panelPeca.Size = new System.Drawing.Size(533, 144);
            this.panelPeca.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(383, 104);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(111, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(380, 89);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.label5_Click);
            // 
            // CadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 228);
            this.Controls.Add(this.panelPeca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.Name = "CadastrarPecas";
            this.Text = "Cadastro de Peças";
            this.panelPeca.ResumeLayout(false);
            this.panelPeca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPecaServico;
        private System.Windows.Forms.TextBox txtKmTroca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelPeca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
    }
}