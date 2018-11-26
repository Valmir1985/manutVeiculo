namespace manutVeiculo
{
    partial class CadastrarCliente
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
            this.gpbInfoPessoal = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNovoCpf = new System.Windows.Forms.Label();
            this.lbNovoNome = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.lbUf = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lbNro = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.gpbInfoPessoal.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfoPessoal
            // 
            this.gpbInfoPessoal.Controls.Add(this.rbtnMasc);
            this.gpbInfoPessoal.Controls.Add(this.rbtnFem);
            this.gpbInfoPessoal.Controls.Add(this.lbSexo);
            this.gpbInfoPessoal.Controls.Add(this.txtCpf);
            this.gpbInfoPessoal.Controls.Add(this.txtNome);
            this.gpbInfoPessoal.Controls.Add(this.lbNovoCpf);
            this.gpbInfoPessoal.Controls.Add(this.lbNovoNome);
            this.gpbInfoPessoal.Location = new System.Drawing.Point(12, 16);
            this.gpbInfoPessoal.Name = "gpbInfoPessoal";
            this.gpbInfoPessoal.Size = new System.Drawing.Size(588, 104);
            this.gpbInfoPessoal.TabIndex = 0;
            this.gpbInfoPessoal.TabStop = false;
            this.gpbInfoPessoal.Text = "Informações Pessoais";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(433, 65);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 9;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(330, 65);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 8;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(263, 67);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(37, 13);
            this.lbSexo.TabIndex = 7;
            this.lbSexo.Text = "Sexo: ";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(53, 62);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(517, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lbNovoCpf
            // 
            this.lbNovoCpf.AutoSize = true;
            this.lbNovoCpf.Location = new System.Drawing.Point(6, 67);
            this.lbNovoCpf.Name = "lbNovoCpf";
            this.lbNovoCpf.Size = new System.Drawing.Size(33, 13);
            this.lbNovoCpf.TabIndex = 1;
            this.lbNovoCpf.Text = "CPF: ";
            // 
            // lbNovoNome
            // 
            this.lbNovoNome.AutoSize = true;
            this.lbNovoNome.Location = new System.Drawing.Point(6, 32);
            this.lbNovoNome.Name = "lbNovoNome";
            this.lbNovoNome.Size = new System.Drawing.Size(41, 13);
            this.lbNovoNome.TabIndex = 0;
            this.lbNovoNome.Text = "Nome: ";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.lbUf);
            this.gpbEndereco.Controls.Add(this.lbCidade);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.txtUf);
            this.gpbEndereco.Controls.Add(this.txtNro);
            this.gpbEndereco.Controls.Add(this.lbNro);
            this.gpbEndereco.Controls.Add(this.txtTelefone);
            this.gpbEndereco.Controls.Add(this.txtCep);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lbTel);
            this.gpbEndereco.Controls.Add(this.label3);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.lbRua);
            this.gpbEndereco.Location = new System.Drawing.Point(12, 126);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(588, 134);
            this.gpbEndereco.TabIndex = 7;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Location = new System.Drawing.Point(316, 100);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(24, 13);
            this.lbUf.TabIndex = 15;
            this.lbUf.Text = "UF:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(4, 99);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(43, 13);
            this.lbCidade.TabIndex = 14;
            this.lbCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(53, 96);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(257, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(344, 97);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(52, 20);
            this.txtUf.TabIndex = 12;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(470, 19);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 20);
            this.txtNro.TabIndex = 11;
            // 
            // lbNro
            // 
            this.lbNro.AutoSize = true;
            this.lbNro.Location = new System.Drawing.Point(436, 22);
            this.lbNro.Name = "lbNro";
            this.lbNro.Size = new System.Drawing.Size(30, 13);
            this.lbNro.TabIndex = 10;
            this.lbNro.Text = "Nro: ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(470, 96);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(470, 56);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(53, 57);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(343, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(53, 22);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(344, 20);
            this.txtRua.TabIndex = 5;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(411, 100);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CEP:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(8, 61);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(40, 13);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.Text = "Bairro: ";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(13, 26);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(30, 13);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(179, 293);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 33);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Location = new System.Drawing.Point(370, 293);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarAdd.TabIndex = 9;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            this.btnCancelarAdd.Click += new System.EventHandler(this.btnCancelarAdd_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 346);
            this.Controls.Add(this.btnCancelarAdd);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbInfoPessoal);
            this.MaximizeBox = false;
            this.Name = "CadastrarCliente";
            this.Text = "Cadastro de Clientes";
            this.gpbInfoPessoal.ResumeLayout(false);
            this.gpbInfoPessoal.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfoPessoal;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNovoCpf;
        private System.Windows.Forms.Label lbNovoNome;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelarAdd;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lbNro;
    }
}