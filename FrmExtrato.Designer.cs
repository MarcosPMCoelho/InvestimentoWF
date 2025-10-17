namespace InvestWF
{
    partial class FrmExtrato
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
            this.lblQtdDias = new System.Windows.Forms.Label();
            this.cmbQtdDias = new System.Windows.Forms.ComboBox();
            this.dgExtrato = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtrato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQtdDias
            // 
            this.lblQtdDias.AutoSize = true;
            this.lblQtdDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDias.Location = new System.Drawing.Point(44, 47);
            this.lblQtdDias.Name = "lblQtdDias";
            this.lblQtdDias.Size = new System.Drawing.Size(154, 20);
            this.lblQtdDias.TabIndex = 0;
            this.lblQtdDias.Text = "Quantidade de Dias:";
            // 
            // cmbQtdDias
            // 
            this.cmbQtdDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtdDias.FormattingEnabled = true;
            this.cmbQtdDias.Location = new System.Drawing.Point(204, 39);
            this.cmbQtdDias.Name = "cmbQtdDias";
            this.cmbQtdDias.Size = new System.Drawing.Size(121, 28);
            this.cmbQtdDias.TabIndex = 1;
            this.cmbQtdDias.SelectedIndexChanged += new System.EventHandler(this.cmbQtdDias_SelectedIndexChanged);
            // 
            // dgExtrato
            // 
            this.dgExtrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExtrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Descricao,
            this.Valor,
            this.Tipo,
            this.SaldoAtual});
            this.dgExtrato.Location = new System.Drawing.Point(13, 83);
            this.dgExtrato.Name = "dgExtrato";
            this.dgExtrato.Size = new System.Drawing.Size(775, 355);
            this.dgExtrato.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 700;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // SaldoAtual
            // 
            this.SaldoAtual.DataPropertyName = "saldoAtual";
            this.SaldoAtual.HeaderText = "Saldo Atual";
            this.SaldoAtual.Name = "SaldoAtual";
            this.SaldoAtual.ReadOnly = true;
            // 
            // FrmExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgExtrato);
            this.Controls.Add(this.cmbQtdDias);
            this.Controls.Add(this.lblQtdDias);
            this.Name = "FrmExtrato";
            this.Text = "Extrato";
            this.Load += new System.EventHandler(this.FrmExtrato_Load);
            this.Resize += new System.EventHandler(this.FrmExtrato_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgExtrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtdDias;
        private System.Windows.Forms.ComboBox cmbQtdDias;
        private System.Windows.Forms.DataGridView dgExtrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoAtual;
    }
}