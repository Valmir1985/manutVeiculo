namespace manutVeiculo
{
    partial class HistoricoCliente
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
            this.gpbHistCliente = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtCpfHistorico = new System.Windows.Forms.TextBox();
            this.lbCpfHistorico = new System.Windows.Forms.Label();
            this.dGViewHistCli = new System.Windows.Forms.DataGridView();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbHistCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistCli)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbHistCliente
            // 
            this.gpbHistCliente.Controls.Add(this.dGViewHistCli);
            this.gpbHistCliente.Controls.Add(this.btnCancelar);
            this.gpbHistCliente.Controls.Add(this.btnConfirma);
            this.gpbHistCliente.Controls.Add(this.txtCpfHistorico);
            this.gpbHistCliente.Controls.Add(this.lbCpfHistorico);
            this.gpbHistCliente.Location = new System.Drawing.Point(18, 15);
            this.gpbHistCliente.Name = "gpbHistCliente";
            this.gpbHistCliente.Size = new System.Drawing.Size(765, 567);
            this.gpbHistCliente.TabIndex = 0;
            this.gpbHistCliente.TabStop = false;
            this.gpbHistCliente.Text = "Histórico Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(478, 72);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(185, 72);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(84, 35);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtCpfHistorico
            // 
            this.txtCpfHistorico.Location = new System.Drawing.Point(315, 37);
            this.txtCpfHistorico.Name = "txtCpfHistorico";
            this.txtCpfHistorico.Size = new System.Drawing.Size(127, 20);
            this.txtCpfHistorico.TabIndex = 3;
            // 
            // lbCpfHistorico
            // 
            this.lbCpfHistorico.AutoSize = true;
            this.lbCpfHistorico.Location = new System.Drawing.Point(364, 21);
            this.lbCpfHistorico.Name = "lbCpfHistorico";
            this.lbCpfHistorico.Size = new System.Drawing.Size(27, 13);
            this.lbCpfHistorico.TabIndex = 0;
            this.lbCpfHistorico.Text = "CPF";
            // 
            // dGViewHistCli
            // 
            this.dGViewHistCli.AllowUserToAddRows = false;
            this.dGViewHistCli.AllowUserToDeleteRows = false;
            this.dGViewHistCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewHistCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNome,
            this.columnVeiculo,
            this.columnPlaca,
            this.columnKm,
            this.columnData});
            this.dGViewHistCli.Location = new System.Drawing.Point(25, 126);
            this.dGViewHistCli.Name = "dGViewHistCli";
            this.dGViewHistCli.ReadOnly = true;
            this.dGViewHistCli.Size = new System.Drawing.Size(715, 424);
            this.dGViewHistCli.TabIndex = 7;
            // 
            // columnNome
            // 
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            this.columnNome.ReadOnly = true;
            this.columnNome.Width = 190;
            // 
            // columnVeiculo
            // 
            this.columnVeiculo.HeaderText = "Veículo";
            this.columnVeiculo.Name = "columnVeiculo";
            this.columnVeiculo.ReadOnly = true;
            this.columnVeiculo.Width = 150;
            // 
            // columnPlaca
            // 
            this.columnPlaca.HeaderText = "Placa";
            this.columnPlaca.Name = "columnPlaca";
            this.columnPlaca.ReadOnly = true;
            this.columnPlaca.Width = 110;
            // 
            // columnKm
            // 
            this.columnKm.HeaderText = "Km";
            this.columnKm.Name = "columnKm";
            this.columnKm.ReadOnly = true;
            this.columnKm.Width = 95;
            // 
            // columnData
            // 
            this.columnData.HeaderText = "Data";
            this.columnData.Name = "columnData";
            this.columnData.ReadOnly = true;
            this.columnData.Width = 127;
            // 
            // HistoricoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.gpbHistCliente);
            this.MaximizeBox = false;
            this.Name = "HistoricoCliente";
            this.Text = "Histórico de Clientes";
            this.gpbHistCliente.ResumeLayout(false);
            this.gpbHistCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbHistCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtCpfHistorico;
        private System.Windows.Forms.Label lbCpfHistorico;
        private System.Windows.Forms.DataGridView dGViewHistCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnData;
    }
}