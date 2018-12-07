namespace manutVeiculo
{
    partial class ConsultarOS
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
            this.gbOS = new System.Windows.Forms.GroupBox();
            this.dGViewConsultaOS = new System.Windows.Forms.DataGridView();
            this.ColumnNrOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatusOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewConsultaOS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOS
            // 
            this.gbOS.Controls.Add(this.dGViewConsultaOS);
            this.gbOS.Controls.Add(this.btnCancelar);
            this.gbOS.Controls.Add(this.btnConsultar);
            this.gbOS.Controls.Add(this.txtOS);
            this.gbOS.Controls.Add(this.label1);
            this.gbOS.Location = new System.Drawing.Point(23, 13);
            this.gbOS.Name = "gbOS";
            this.gbOS.Size = new System.Drawing.Size(754, 568);
            this.gbOS.TabIndex = 6;
            this.gbOS.TabStop = false;
            this.gbOS.Text = "Ordem de Serviço";
            // 
            // dGViewConsultaOS
            // 
            this.dGViewConsultaOS.AllowUserToAddRows = false;
            this.dGViewConsultaOS.AllowUserToDeleteRows = false;
            this.dGViewConsultaOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewConsultaOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNrOS,
            this.columnCliente,
            this.columnPlaca,
            this.columnStatusOS});
            this.dGViewConsultaOS.Location = new System.Drawing.Point(26, 143);
            this.dGViewConsultaOS.Name = "dGViewConsultaOS";
            this.dGViewConsultaOS.ReadOnly = true;
            this.dGViewConsultaOS.Size = new System.Drawing.Size(703, 400);
            this.dGViewConsultaOS.TabIndex = 5;
            // 
            // ColumnNrOS
            // 
            this.ColumnNrOS.HeaderText = "Número OS";
            this.ColumnNrOS.Name = "ColumnNrOS";
            this.ColumnNrOS.ReadOnly = true;
            this.ColumnNrOS.Width = 150;
            // 
            // columnCliente
            // 
            this.columnCliente.HeaderText = "Cliente";
            this.columnCliente.Name = "columnCliente";
            this.columnCliente.ReadOnly = true;
            this.columnCliente.Width = 137;
            // 
            // columnPlaca
            // 
            this.columnPlaca.HeaderText = "Placa do Veículo";
            this.columnPlaca.Name = "columnPlaca";
            this.columnPlaca.ReadOnly = true;
            this.columnPlaca.Width = 135;
            // 
            // columnStatusOS
            // 
            this.columnStatusOS.HeaderText = "Status da OS";
            this.columnStatusOS.Name = "columnStatusOS";
            this.columnStatusOS.ReadOnly = true;
            this.columnStatusOS.Width = 238;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(190, 89);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 35);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(308, 43);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(124, 20);
            this.txtOS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro da OS";
            // 
            // ConsultarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.gbOS);
            this.Name = "ConsultarOS";
            this.Text = "ConsultaOS";
            this.gbOS.ResumeLayout(false);
            this.gbOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewConsultaOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOS;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGViewConsultaOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNrOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatusOS;
    }
}