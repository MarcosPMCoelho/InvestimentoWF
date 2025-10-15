namespace InvestWF
{
    partial class FrmAnalise
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
            this.dgAnalise = new System.Windows.Forms.DataGridView();
            this.papel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_cotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possibilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnalise)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnalise
            // 
            this.dgAnalise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnalise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papel,
            this.quantidade,
            this.vl_unit,
            this.pm,
            this.valor_cotacao,
            this.TotalAtual,
            this.dataOperacao,
            this.minimoVenda,
            this.dataCotacao,
            this.TotalCompra,
            this.possibilidade,
            this.Resultado});
            this.dgAnalise.Location = new System.Drawing.Point(13, 12);
            this.dgAnalise.Name = "dgAnalise";
            this.dgAnalise.Size = new System.Drawing.Size(1304, 516);
            this.dgAnalise.TabIndex = 0;
            this.dgAnalise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnalise_CellContentClick);
            this.dgAnalise.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgAnalise_CellFormatting);
            // 
            // papel
            // 
            this.papel.DataPropertyName = "papel";
            this.papel.HeaderText = "Papel";
            this.papel.Name = "papel";
            this.papel.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // vl_unit
            // 
            this.vl_unit.DataPropertyName = "vl_unit";
            this.vl_unit.HeaderText = "Valor Unitário";
            this.vl_unit.Name = "vl_unit";
            this.vl_unit.ReadOnly = true;
            // 
            // pm
            // 
            this.pm.DataPropertyName = "pm";
            this.pm.HeaderText = "Preço Médio";
            this.pm.Name = "pm";
            this.pm.ReadOnly = true;
            // 
            // valor_cotacao
            // 
            this.valor_cotacao.DataPropertyName = "valor_cotacao";
            this.valor_cotacao.HeaderText = "Valor Cotação";
            this.valor_cotacao.Name = "valor_cotacao";
            this.valor_cotacao.ReadOnly = true;
            // 
            // TotalAtual
            // 
            this.TotalAtual.HeaderText = "Total Atual";
            this.TotalAtual.Name = "TotalAtual";
            this.TotalAtual.ReadOnly = true;
            // 
            // dataOperacao
            // 
            this.dataOperacao.DataPropertyName = "dataOperacao";
            this.dataOperacao.HeaderText = "Data Operação";
            this.dataOperacao.Name = "dataOperacao";
            this.dataOperacao.ReadOnly = true;
            // 
            // minimoVenda
            // 
            this.minimoVenda.DataPropertyName = "minimoVenda";
            this.minimoVenda.HeaderText = "Mínimo Venda";
            this.minimoVenda.Name = "minimoVenda";
            this.minimoVenda.ReadOnly = true;
            // 
            // dataCotacao
            // 
            this.dataCotacao.DataPropertyName = "dataCotacao";
            this.dataCotacao.HeaderText = "Data Cotação";
            this.dataCotacao.Name = "dataCotacao";
            this.dataCotacao.ReadOnly = true;
            // 
            // TotalCompra
            // 
            this.TotalCompra.HeaderText = "TotalCompra";
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.ReadOnly = true;
            // 
            // possibilidade
            // 
            this.possibilidade.DataPropertyName = "possibilidade";
            this.possibilidade.HeaderText = "Possibilidade";
            this.possibilidade.Name = "possibilidade";
            this.possibilidade.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.DataPropertyName = "resultado";
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            // 
            // FrmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.Controls.Add(this.dgAnalise);
            this.Name = "FrmAnalise";
            this.Text = "Análise";
            this.Load += new System.EventHandler(this.FrmAnalise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnalise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn papel;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_cotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn possibilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}