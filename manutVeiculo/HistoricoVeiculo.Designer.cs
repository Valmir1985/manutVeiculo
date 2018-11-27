namespace manutVeiculo
{
    partial class HistoricoVeiculo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbHistVeiculo = new System.Windows.Forms.GroupBox();
            this.dGViewHistVeiculo = new System.Windows.Forms.DataGridView();
            this.columnPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHistVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbHistVeiculo
            // 
            this.gbHistVeiculo.Controls.Add(this.dGViewHistVeiculo);
            this.gbHistVeiculo.Controls.Add(this.button2);
            this.gbHistVeiculo.Controls.Add(this.button1);
            this.gbHistVeiculo.Controls.Add(this.textBox1);
            this.gbHistVeiculo.Controls.Add(this.label1);
            this.gbHistVeiculo.Location = new System.Drawing.Point(21, 14);
            this.gbHistVeiculo.Name = "gbHistVeiculo";
            this.gbHistVeiculo.Size = new System.Drawing.Size(754, 568);
            this.gbHistVeiculo.TabIndex = 5;
            this.gbHistVeiculo.TabStop = false;
            this.gbHistVeiculo.Text = "Histórico do Veículo";
            // 
            // dGViewHistVeiculo
            // 
            this.dGViewHistVeiculo.AllowUserToAddRows = false;
            this.dGViewHistVeiculo.AllowUserToDeleteRows = false;
            this.dGViewHistVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewHistVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPeca,
            this.columnKm,
            this.columnData,
            this.columnProprietario});
            this.dGViewHistVeiculo.Location = new System.Drawing.Point(26, 141);
            this.dGViewHistVeiculo.Name = "dGViewHistVeiculo";
            this.dGViewHistVeiculo.ReadOnly = true;
            this.dGViewHistVeiculo.Size = new System.Drawing.Size(703, 402);
            this.dGViewHistVeiculo.TabIndex = 5;
            // 
            // columnPeca
            // 
            this.columnPeca.HeaderText = "Peça";
            this.columnPeca.Name = "columnPeca";
            this.columnPeca.ReadOnly = true;
            this.columnPeca.Width = 150;
            // 
            // columnKm
            // 
            this.columnKm.HeaderText = "Km";
            this.columnKm.Name = "columnKm";
            this.columnKm.ReadOnly = true;
            this.columnKm.Width = 140;
            // 
            // columnData
            // 
            this.columnData.HeaderText = "Data";
            this.columnData.Name = "columnData";
            this.columnData.ReadOnly = true;
            this.columnData.Width = 130;
            // 
            // columnProprietario
            // 
            this.columnProprietario.HeaderText = "Proprietario";
            this.columnProprietario.Name = "columnProprietario";
            this.columnProprietario.ReadOnly = true;
            this.columnProprietario.Width = 240;
            // 
            // HistoricoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.gbHistVeiculo);
            this.MaximizeBox = false;
            this.Name = "HistoricoVeiculo";
            this.Text = "Consulta Histórico do Veículo";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.gbHistVeiculo.ResumeLayout(false);
            this.gbHistVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbHistVeiculo;
        private System.Windows.Forms.DataGridView dGViewHistVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProprietario;
    }
}