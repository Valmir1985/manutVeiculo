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
            this.button2 = new System.Windows.Forms.Button();
            this.listStatusOS = new System.Windows.Forms.ListView();
            this.numeroOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOS
            // 
            this.gbOS.Controls.Add(this.button2);
            this.gbOS.Controls.Add(this.listStatusOS);
            this.gbOS.Controls.Add(this.button1);
            this.gbOS.Controls.Add(this.txtOS);
            this.gbOS.Controls.Add(this.label1);
            this.gbOS.Location = new System.Drawing.Point(23, 13);
            this.gbOS.Name = "gbOS";
            this.gbOS.Size = new System.Drawing.Size(754, 568);
            this.gbOS.TabIndex = 6;
            this.gbOS.TabStop = false;
            this.gbOS.Text = "Ordem de Serviço";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listStatusOS
            // 
            this.listStatusOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numeroOS,
            this.cliente,
            this.placa,
            this.status});
            this.listStatusOS.Location = new System.Drawing.Point(26, 136);
            this.listStatusOS.Name = "listStatusOS";
            this.listStatusOS.Size = new System.Drawing.Size(703, 407);
            this.listStatusOS.TabIndex = 4;
            this.listStatusOS.UseCompatibleStateImageBehavior = false;
            this.listStatusOS.View = System.Windows.Forms.View.Details;
            this.listStatusOS.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // numeroOS
            // 
            this.numeroOS.Text = "Número OS";
            this.numeroOS.Width = 189;
            // 
            // cliente
            // 
            this.cliente.Text = "Cliente";
            this.cliente.Width = 139;
            // 
            // placa
            // 
            this.placa.Text = "Placa do Veículo";
            this.placa.Width = 134;
            // 
            // status
            // 
            this.status.Text = "Status OS";
            this.status.Width = 235;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listStatusOS;
        private System.Windows.Forms.ColumnHeader numeroOS;
        private System.Windows.Forms.ColumnHeader cliente;
        private System.Windows.Forms.ColumnHeader placa;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label1;
    }
}