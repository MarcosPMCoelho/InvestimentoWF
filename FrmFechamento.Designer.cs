namespace InvestWF
{
    partial class FrmFechamento
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
            this.dgFechamento = new System.Windows.Forms.DataGridView();
            this.DataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_Aplicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFundo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFechamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFechamento
            // 
            this.dgFechamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFechamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFechamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataFechamento,
            this.total_Aplicado,
            this.fechamento,
            this.Total,
            this.SaldoFundo,
            this.SaldoPrev,
            this.SaldoCC,
            this.SaldoFinal});
            this.dgFechamento.Location = new System.Drawing.Point(12, 68);
            this.dgFechamento.Name = "dgFechamento";
            this.dgFechamento.Size = new System.Drawing.Size(931, 370);
            this.dgFechamento.TabIndex = 0;
            this.dgFechamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFechamento_CellContentClick);
            this.dgFechamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFechamento_CellFormatting);
            // 
            // DataFechamento
            // 
            this.DataFechamento.DataPropertyName = "dataFechamento";
            this.DataFechamento.HeaderText = "Data Fechamento";
            this.DataFechamento.Name = "DataFechamento";
            this.DataFechamento.ReadOnly = true;
            // 
            // total_Aplicado
            // 
            this.total_Aplicado.DataPropertyName = "total_Aplicado";
            this.total_Aplicado.HeaderText = "Total Aplicado";
            this.total_Aplicado.Name = "total_Aplicado";
            this.total_Aplicado.ReadOnly = true;
            // 
            // fechamento
            // 
            this.fechamento.DataPropertyName = "fechamento";
            this.fechamento.HeaderText = "Fechamento";
            this.fechamento.Name = "fechamento";
            this.fechamento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // SaldoFundo
            // 
            this.SaldoFundo.DataPropertyName = "saldo_Fundo";
            this.SaldoFundo.HeaderText = "Saldo Fundo";
            this.SaldoFundo.Name = "SaldoFundo";
            this.SaldoFundo.ReadOnly = true;
            // 
            // SaldoPrev
            // 
            this.SaldoPrev.DataPropertyName = "saldo_Prev";
            this.SaldoPrev.HeaderText = "Saldo Prev";
            this.SaldoPrev.Name = "SaldoPrev";
            this.SaldoPrev.ReadOnly = true;
            // 
            // SaldoCC
            // 
            this.SaldoCC.DataPropertyName = "saldo_CC";
            this.SaldoCC.HeaderText = "Saldo CC";
            this.SaldoCC.Name = "SaldoCC";
            this.SaldoCC.ReadOnly = true;
            // 
            // SaldoFinal
            // 
            this.SaldoFinal.HeaderText = "Saldo Final";
            this.SaldoFinal.Name = "SaldoFinal";
            this.SaldoFinal.ReadOnly = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(24, 23);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgFechamento);
            this.Name = "FrmFechamento";
            this.Text = "Fechamento";
            this.Load += new System.EventHandler(this.FrmFechamento_Load);
            this.Resize += new System.EventHandler(this.FrmFechamento_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgFechamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFechamento;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_Aplicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFundo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
    }
}