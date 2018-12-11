namespace manutVeiculo
{
    partial class OrdemServico
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
            this.gpbOs = new System.Windows.Forms.GroupBox();
            this.dGViewHistVeiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnData1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtOs = new System.Windows.Forms.TextBox();
            this.lbOs = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gpbOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbOs
            // 
            this.gpbOs.Controls.Add(this.dGViewHistVeiculo);
            this.gpbOs.Controls.Add(this.btnCancel);
            this.gpbOs.Controls.Add(this.btnFinaliza);
            this.gpbOs.Controls.Add(this.btnVisualizar);
            this.gpbOs.Controls.Add(this.txtOs);
            this.gpbOs.Controls.Add(this.lbOs);
            this.gpbOs.Location = new System.Drawing.Point(18, 11);
            this.gpbOs.Name = "gpbOs";
            this.gpbOs.Size = new System.Drawing.Size(765, 567);
            this.gpbOs.TabIndex = 1;
            this.gpbOs.TabStop = false;
            this.gpbOs.Text = "Ordem de Serviço";
            // 
            // dGViewHistVeiculo
            // 
            this.dGViewHistVeiculo.AllowUserToAddRows = false;
            this.dGViewHistVeiculo.AllowUserToDeleteRows = false;
            this.dGViewHistVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewHistVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.columnProprietario,
            this.columnData1});
            this.dGViewHistVeiculo.Location = new System.Drawing.Point(25, 87);
            this.dGViewHistVeiculo.Name = "dGViewHistVeiculo";
            this.dGViewHistVeiculo.ReadOnly = true;
            this.dGViewHistVeiculo.Size = new System.Drawing.Size(715, 408);
            this.dGViewHistVeiculo.TabIndex = 11;
            this.dGViewHistVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGViewHistVeiculo_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Peça";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Km";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // columnProprietario
            // 
            this.columnProprietario.HeaderText = "Valor";
            this.columnProprietario.Name = "columnProprietario";
            this.columnProprietario.ReadOnly = true;
            this.columnProprietario.Width = 150;
            // 
            // columnData1
            // 
            this.columnData1.HeaderText = "Data";
            this.columnData1.Name = "columnData1";
            this.columnData1.ReadOnly = true;
            this.columnData1.Width = 140;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(210, 517);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(84, 35);
            this.btnFinaliza.TabIndex = 9;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(466, 33);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(84, 35);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtOs
            // 
            this.txtOs.Location = new System.Drawing.Point(235, 41);
            this.txtOs.Name = "txtOs";
            this.txtOs.Size = new System.Drawing.Size(203, 20);
            this.txtOs.TabIndex = 3;
            // 
            // lbOs
            // 
            this.lbOs.AutoSize = true;
            this.lbOs.Location = new System.Drawing.Point(297, 25);
            this.lbOs.Name = "lbOs";
            this.lbOs.Size = new System.Drawing.Size(83, 13);
            this.lbOs.TabIndex = 0;
            this.lbOs.Text = "Número da O.S.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(127, 298);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 33);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // OrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.gpbOs);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.MaximizeBox = false;
            this.Name = "OrdemServico";
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.OrdemServico_Load);
            this.gpbOs.ResumeLayout(false);
            this.gpbOs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewHistVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtOs;
        private System.Windows.Forms.Label lbOs;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.DataGridView dGViewHistVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnData1;
    }
}