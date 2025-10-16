namespace InvestWF
{
    partial class FrmCotacao
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
            this.components = new System.ComponentModel.Container();
            this.dgCotacao = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAtualizaOnline = new System.Windows.Forms.Button();
            this.dgPendente = new System.Windows.Forms.DataGridView();
            this.lblCotacaoPendente = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCotacao
            // 
            this.dgCotacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCotacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCotacao.Location = new System.Drawing.Point(12, 12);
            this.dgCotacao.Name = "dgCotacao";
            this.dgCotacao.Size = new System.Drawing.Size(846, 517);
            this.dgCotacao.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAtualizaOnline
            // 
            this.btnAtualizaOnline.Location = new System.Drawing.Point(12, 535);
            this.btnAtualizaOnline.Name = "btnAtualizaOnline";
            this.btnAtualizaOnline.Size = new System.Drawing.Size(135, 23);
            this.btnAtualizaOnline.TabIndex = 2;
            this.btnAtualizaOnline.Text = "Atualizar Online";
            this.btnAtualizaOnline.UseVisualStyleBackColor = true;
            this.btnAtualizaOnline.Click += new System.EventHandler(this.btnAtualizaOnline_Click);
            // 
            // dgPendente
            // 
            this.dgPendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendente.Location = new System.Drawing.Point(14, 564);
            this.dgPendente.Name = "dgPendente";
            this.dgPendente.Size = new System.Drawing.Size(843, 217);
            this.dgPendente.TabIndex = 3;
            // 
            // lblCotacaoPendente
            // 
            this.lblCotacaoPendente.AutoSize = true;
            this.lblCotacaoPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotacaoPendente.Location = new System.Drawing.Point(153, 538);
            this.lblCotacaoPendente.Name = "lblCotacaoPendente";
            this.lblCotacaoPendente.Size = new System.Drawing.Size(142, 20);
            this.lblCotacaoPendente.TabIndex = 4;
            this.lblCotacaoPendente.Text = "Cotação Pendente";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(362, 535);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(128, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Nova Cotação";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(496, 535);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(128, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar Cotação";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(630, 535);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Cotação";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 793);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblCotacaoPendente);
            this.Controls.Add(this.dgPendente);
            this.Controls.Add(this.btnAtualizaOnline);
            this.Controls.Add(this.dgCotacao);
            this.Name = "FrmCotacao";
            this.Text = "Cotação";
            this.Load += new System.EventHandler(this.FrmCotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCotacao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAtualizaOnline;
        private System.Windows.Forms.DataGridView dgPendente;
        private System.Windows.Forms.Label lblCotacaoPendente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}