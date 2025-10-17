namespace InvestWF
{
    partial class FrmResultado
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
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.Papel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dividendos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMeses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PmDividendos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DividendosUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DividendoYiled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotalAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultadoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Papel,
            this.Quantidade,
            this.PrecoMedio,
            this.ValorTotal,
            this.Dividendos,
            this.QtdMeses,
            this.PmDividendos,
            this.DividendosUnit,
            this.DividendoYiled,
            this.DataCotacao,
            this.Valor,
            this.ValorTotalAtual,
            this.ResultadoFinal});
            this.dgResultado.Location = new System.Drawing.Point(12, 12);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.Size = new System.Drawing.Size(1287, 400);
            this.dgResultado.TabIndex = 0;
            this.dgResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgResultado_CellFormatting);
            // 
            // Papel
            // 
            this.Papel.DataPropertyName = "papel";
            this.Papel.HeaderText = "Papel";
            this.Papel.Name = "Papel";
            this.Papel.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoMedio
            // 
            this.PrecoMedio.DataPropertyName = "pm";
            this.PrecoMedio.HeaderText = "Preço Médio";
            this.PrecoMedio.Name = "PrecoMedio";
            this.PrecoMedio.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "vl_total";
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // Dividendos
            // 
            this.Dividendos.DataPropertyName = "dividendos";
            this.Dividendos.HeaderText = "Dividendos";
            this.Dividendos.Name = "Dividendos";
            this.Dividendos.ReadOnly = true;
            // 
            // QtdMeses
            // 
            this.QtdMeses.DataPropertyName = "qtd_meses";
            this.QtdMeses.HeaderText = "Qtd Meses";
            this.QtdMeses.Name = "QtdMeses";
            this.QtdMeses.ReadOnly = true;
            // 
            // PmDividendos
            // 
            this.PmDividendos.DataPropertyName = "pm_dividendos";
            this.PmDividendos.HeaderText = "PM Dividendos";
            this.PmDividendos.Name = "PmDividendos";
            this.PmDividendos.ReadOnly = true;
            // 
            // DividendosUnit
            // 
            this.DividendosUnit.DataPropertyName = "dividendos_unit";
            this.DividendosUnit.HeaderText = "Dividendos Unit";
            this.DividendosUnit.Name = "DividendosUnit";
            this.DividendosUnit.ReadOnly = true;
            // 
            // DividendoYiled
            // 
            this.DividendoYiled.DataPropertyName = "dividendoYiled";
            this.DividendoYiled.HeaderText = "Dividendo Yield";
            this.DividendoYiled.Name = "DividendoYiled";
            this.DividendoYiled.ReadOnly = true;
            // 
            // DataCotacao
            // 
            this.DataCotacao.DataPropertyName = "data_cotacao";
            this.DataCotacao.HeaderText = "Data Cotação";
            this.DataCotacao.Name = "DataCotacao";
            this.DataCotacao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // ValorTotalAtual
            // 
            this.ValorTotalAtual.DataPropertyName = "valor_total_atual";
            this.ValorTotalAtual.HeaderText = "Valor Total Atual";
            this.ValorTotalAtual.Name = "ValorTotalAtual";
            this.ValorTotalAtual.ReadOnly = true;
            // 
            // ResultadoFinal
            // 
            this.ResultadoFinal.DataPropertyName = "resultado_final";
            this.ResultadoFinal.HeaderText = "Resultado Final";
            this.ResultadoFinal.Name = "ResultadoFinal";
            this.ResultadoFinal.ReadOnly = true;
            // 
            // FrmResultado
            // 
            this.ClientSize = new System.Drawing.Size(1379, 424);
            this.Controls.Add(this.dgResultado);
            this.Name = "FrmResultado";
            this.Load += new System.EventHandler(this.FrmResultado_Load);
            this.Resize += new System.EventHandler(this.FrmResultado_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbResultado;
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Papel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dividendos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn PmDividendos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DividendosUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DividendoYiled;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotalAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultadoFinal;
    }
}