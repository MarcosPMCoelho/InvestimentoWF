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
            this.dbPendente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPendente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCotacao
            // 
            this.dgCotacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCotacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCotacao.Location = new System.Drawing.Point(12, 12);
            this.dgCotacao.Name = "dgCotacao";
            this.dgCotacao.Size = new System.Drawing.Size(846, 555);
            this.dgCotacao.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAtualizaOnline
            // 
            this.btnAtualizaOnline.Location = new System.Drawing.Point(12, 573);
            this.btnAtualizaOnline.Name = "btnAtualizaOnline";
            this.btnAtualizaOnline.Size = new System.Drawing.Size(135, 23);
            this.btnAtualizaOnline.TabIndex = 2;
            this.btnAtualizaOnline.Text = "Atualizar Online";
            this.btnAtualizaOnline.UseVisualStyleBackColor = true;
            this.btnAtualizaOnline.Click += new System.EventHandler(this.btnAtualizaOnline_Click);
            // 
            // dbPendente
            // 
            this.dbPendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbPendente.Location = new System.Drawing.Point(14, 606);
            this.dbPendente.Name = "dbPendente";
            this.dbPendente.Size = new System.Drawing.Size(843, 175);
            this.dbPendente.TabIndex = 3;
            // 
            // FrmCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 793);
            this.Controls.Add(this.dbPendente);
            this.Controls.Add(this.btnAtualizaOnline);
            this.Controls.Add(this.dgCotacao);
            this.Name = "FrmCotacao";
            this.Text = "Cotação";
            this.Load += new System.EventHandler(this.FrmCotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPendente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCotacao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAtualizaOnline;
        private System.Windows.Forms.DataGridView dbPendente;
    }
}