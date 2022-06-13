namespace ProgFormularioEngenharia2.sondagem
{
    partial class Frm_Fotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fotos));
            this.pct_boxMaior = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_boxMaior)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_boxMaior
            // 
            this.pct_boxMaior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_boxMaior.Location = new System.Drawing.Point(40, 26);
            this.pct_boxMaior.Name = "pct_boxMaior";
            this.pct_boxMaior.Size = new System.Drawing.Size(773, 525);
            this.pct_boxMaior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_boxMaior.TabIndex = 0;
            this.pct_boxMaior.TabStop = false;
            // 
            // Frm_Fotos
            // 
            this.ClientSize = new System.Drawing.Size(794, 527);
            this.Controls.Add(this.pct_boxMaior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Fotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotos";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Fotos_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.pct_boxMaior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pct_boxMaior;
    }
}