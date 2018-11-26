namespace manutVeiculo
{
    partial class CadastrarVeiculo
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
            this.gpbVeiculo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbKm = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.gpbVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbVeiculo
            // 
            this.gpbVeiculo.Controls.Add(this.comboBox1);
            this.gpbVeiculo.Controls.Add(this.txtCor);
            this.gpbVeiculo.Controls.Add(this.txtPlaca);
            this.gpbVeiculo.Controls.Add(this.txtKmRodado);
            this.gpbVeiculo.Controls.Add(this.txtAno);
            this.gpbVeiculo.Controls.Add(this.txtMarca);
            this.gpbVeiculo.Controls.Add(this.lbKm);
            this.gpbVeiculo.Controls.Add(this.lbCombustivel);
            this.gpbVeiculo.Controls.Add(this.lbAno);
            this.gpbVeiculo.Controls.Add(this.lbPlaca);
            this.gpbVeiculo.Controls.Add(this.lbModelo);
            this.gpbVeiculo.Controls.Add(this.lbMarca);
            this.gpbVeiculo.Location = new System.Drawing.Point(12, 24);
            this.gpbVeiculo.Name = "gpbVeiculo";
            this.gpbVeiculo.Size = new System.Drawing.Size(588, 169);
            this.gpbVeiculo.TabIndex = 11;
            this.gpbVeiculo.TabStop = false;
            this.gpbVeiculo.Text = "Informações do Veículo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Gasolina",
            "Etanol",
            "Diesel"});
            this.comboBox1.Location = new System.Drawing.Point(95, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(396, 116);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(126, 20);
            this.txtCor.TabIndex = 15;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(396, 68);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(126, 20);
            this.txtPlaca.TabIndex = 14;
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(95, 118);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(180, 20);
            this.txtKmRodado.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(396, 23);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(126, 20);
            this.txtAno.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(180, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.Location = new System.Drawing.Point(26, 123);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(63, 13);
            this.lbKm.TabIndex = 5;
            this.lbKm.Text = "Km/rodado:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Location = new System.Drawing.Point(20, 72);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(69, 13);
            this.lbCombustivel.TabIndex = 4;
            this.lbCombustivel.Text = "Combustível:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(359, 124);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 13);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "Ano:";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(353, 74);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 2;
            this.lbPlaca.Text = "Placa:";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(345, 29);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(48, 13);
            this.lbModelo.TabIndex = 1;
            this.lbModelo.Text = "Modelo: ";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(46, 29);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(177, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 33);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Location = new System.Drawing.Point(360, 225);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarAdd.TabIndex = 13;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            this.btnCancelarAdd.Click += new System.EventHandler(this.btnCancelarAdd_Click);
            // 
            // CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 281);
            this.Controls.Add(this.btnCancelarAdd);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbVeiculo);
            this.Name = "CadastrarVeiculo";
            this.Text = "Cadastro de Veículo";
            this.gpbVeiculo.ResumeLayout(false);
            this.gpbVeiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVeiculo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelarAdd;
    }
}