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
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(12, 12);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.Size = new System.Drawing.Size(1287, 400);
            this.dgResultado.TabIndex = 0;
            this.dgResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgResultado_CellFormatting);
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
    }
}