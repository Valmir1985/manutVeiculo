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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.lvOs = new System.Windows.Forms.ListView();
            this.columnTroca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPeca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtOs = new System.Windows.Forms.TextBox();
            this.lbOs = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gpbOs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOs
            // 
            this.gpbOs.Controls.Add(this.btnCancel);
            this.gpbOs.Controls.Add(this.btnFinaliza);
            this.gpbOs.Controls.Add(this.lvOs);
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
            // 
            // lvOs
            // 
            this.lvOs.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvOs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTroca,
            this.columnPeca,
            this.columnKm,
            this.columnValor});
            this.lvOs.HoverSelection = true;
            this.lvOs.Location = new System.Drawing.Point(25, 79);
            this.lvOs.Name = "lvOs";
            this.lvOs.Size = new System.Drawing.Size(715, 416);
            this.lvOs.TabIndex = 8;
            this.lvOs.UseCompatibleStateImageBehavior = false;
            this.lvOs.View = System.Windows.Forms.View.Details;
            // 
            // columnTroca
            // 
            this.columnTroca.Text = "Troca";
            this.columnTroca.Width = 195;
            // 
            // columnPeca
            // 
            this.columnPeca.Text = "Peça";
            this.columnPeca.Width = 219;
            // 
            // columnKm
            // 
            this.columnKm.Text = "Km";
            this.columnKm.Width = 143;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 153;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.gpbOs);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Ordem de Serviço";
            this.gpbOs.ResumeLayout(false);
            this.gpbOs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtOs;
        private System.Windows.Forms.Label lbOs;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ListView lvOs;
        private System.Windows.Forms.ColumnHeader columnTroca;
        private System.Windows.Forms.ColumnHeader columnPeca;
        private System.Windows.Forms.ColumnHeader columnKm;
        private System.Windows.Forms.ColumnHeader columnValor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinaliza;
    }
}