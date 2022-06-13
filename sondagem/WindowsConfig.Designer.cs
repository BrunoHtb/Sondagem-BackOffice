
namespace ProgFormularioEngenharia2
{
    partial class Frm_Configuração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuração));
            this.lbl_ipBD = new System.Windows.Forms.Label();
            this.lbl_folderImage = new System.Windows.Forms.Label();
            this.txtB_folderImage = new System.Windows.Forms.TextBox();
            this.btn_folderImage = new System.Windows.Forms.Button();
            this.txtB_ipBancoDado = new System.Windows.Forms.TextBox();
            this.btn_salvarConfig = new System.Windows.Forms.Button();
            this.btn_fecharConfig = new System.Windows.Forms.Button();
            this.pctB_logo = new System.Windows.Forms.PictureBox();
            this.btn_folderWord = new System.Windows.Forms.Button();
            this.txtB_wordDocument = new System.Windows.Forms.TextBox();
            this.lbl_wordDocument = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ipBD
            // 
            this.lbl_ipBD.AutoSize = true;
            this.lbl_ipBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ipBD.Location = new System.Drawing.Point(12, 163);
            this.lbl_ipBD.Name = "lbl_ipBD";
            this.lbl_ipBD.Size = new System.Drawing.Size(60, 30);
            this.lbl_ipBD.TabIndex = 0;
            this.lbl_ipBD.Text = "Host do \r\nBanco";
            // 
            // lbl_folderImage
            // 
            this.lbl_folderImage.AutoSize = true;
            this.lbl_folderImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_folderImage.Location = new System.Drawing.Point(12, 214);
            this.lbl_folderImage.Name = "lbl_folderImage";
            this.lbl_folderImage.Size = new System.Drawing.Size(83, 30);
            this.lbl_folderImage.TabIndex = 1;
            this.lbl_folderImage.Text = "Diretório de\r\n  Imagens";
            // 
            // txtB_folderImage
            // 
            this.txtB_folderImage.Location = new System.Drawing.Point(101, 224);
            this.txtB_folderImage.Name = "txtB_folderImage";
            this.txtB_folderImage.Size = new System.Drawing.Size(174, 20);
            this.txtB_folderImage.TabIndex = 2;
            // 
            // btn_folderImage
            // 
            this.btn_folderImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_folderImage.Location = new System.Drawing.Point(281, 224);
            this.btn_folderImage.Name = "btn_folderImage";
            this.btn_folderImage.Size = new System.Drawing.Size(31, 20);
            this.btn_folderImage.TabIndex = 3;
            this.btn_folderImage.Text = "...";
            this.btn_folderImage.UseVisualStyleBackColor = true;
            this.btn_folderImage.Click += new System.EventHandler(this.btn_folderImage_Click);
            // 
            // txtB_ipBancoDado
            // 
            this.txtB_ipBancoDado.Location = new System.Drawing.Point(101, 173);
            this.txtB_ipBancoDado.Name = "txtB_ipBancoDado";
            this.txtB_ipBancoDado.Size = new System.Drawing.Size(174, 20);
            this.txtB_ipBancoDado.TabIndex = 4;
            // 
            // btn_salvarConfig
            // 
            this.btn_salvarConfig.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_salvarConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarConfig.Location = new System.Drawing.Point(69, 311);
            this.btn_salvarConfig.Name = "btn_salvarConfig";
            this.btn_salvarConfig.Size = new System.Drawing.Size(85, 40);
            this.btn_salvarConfig.TabIndex = 5;
            this.btn_salvarConfig.Text = "Salvar";
            this.btn_salvarConfig.UseVisualStyleBackColor = false;
            this.btn_salvarConfig.Click += new System.EventHandler(this.btn_salvarConfig_Click);
            // 
            // btn_fecharConfig
            // 
            this.btn_fecharConfig.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fecharConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharConfig.Location = new System.Drawing.Point(190, 311);
            this.btn_fecharConfig.Name = "btn_fecharConfig";
            this.btn_fecharConfig.Size = new System.Drawing.Size(85, 40);
            this.btn_fecharConfig.TabIndex = 6;
            this.btn_fecharConfig.Text = "Fechar";
            this.btn_fecharConfig.UseVisualStyleBackColor = false;
            this.btn_fecharConfig.Click += new System.EventHandler(this.btn_fecharConfig_Click);
            // 
            // pctB_logo
            // 
            this.pctB_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctB_logo.Image = ((System.Drawing.Image)(resources.GetObject("pctB_logo.Image")));
            this.pctB_logo.Location = new System.Drawing.Point(110, 12);
            this.pctB_logo.Name = "pctB_logo";
            this.pctB_logo.Size = new System.Drawing.Size(128, 128);
            this.pctB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctB_logo.TabIndex = 7;
            this.pctB_logo.TabStop = false;
            // 
            // btn_folderWord
            // 
            this.btn_folderWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_folderWord.Location = new System.Drawing.Point(281, 268);
            this.btn_folderWord.Name = "btn_folderWord";
            this.btn_folderWord.Size = new System.Drawing.Size(31, 20);
            this.btn_folderWord.TabIndex = 10;
            this.btn_folderWord.Text = "...";
            this.btn_folderWord.UseVisualStyleBackColor = true;
            this.btn_folderWord.Click += new System.EventHandler(this.btn_folderWord_Click);
            // 
            // txtB_wordDocument
            // 
            this.txtB_wordDocument.Location = new System.Drawing.Point(101, 268);
            this.txtB_wordDocument.Name = "txtB_wordDocument";
            this.txtB_wordDocument.Size = new System.Drawing.Size(174, 20);
            this.txtB_wordDocument.TabIndex = 9;
            // 
            // lbl_wordDocument
            // 
            this.lbl_wordDocument.AutoSize = true;
            this.lbl_wordDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wordDocument.Location = new System.Drawing.Point(12, 258);
            this.lbl_wordDocument.Name = "lbl_wordDocument";
            this.lbl_wordDocument.Size = new System.Drawing.Size(87, 30);
            this.lbl_wordDocument.TabIndex = 8;
            this.lbl_wordDocument.Text = "Diretório do \r\n     Word";
            // 
            // Frm_Configuração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 363);
            this.Controls.Add(this.btn_folderWord);
            this.Controls.Add(this.txtB_wordDocument);
            this.Controls.Add(this.lbl_wordDocument);
            this.Controls.Add(this.pctB_logo);
            this.Controls.Add(this.btn_fecharConfig);
            this.Controls.Add(this.btn_salvarConfig);
            this.Controls.Add(this.txtB_ipBancoDado);
            this.Controls.Add(this.btn_folderImage);
            this.Controls.Add(this.txtB_folderImage);
            this.Controls.Add(this.lbl_folderImage);
            this.Controls.Add(this.lbl_ipBD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Configuração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pctB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ipBD;
        private System.Windows.Forms.Label lbl_folderImage;
        private System.Windows.Forms.TextBox txtB_folderImage;
        private System.Windows.Forms.Button btn_folderImage;
        private System.Windows.Forms.TextBox txtB_ipBancoDado;
        private System.Windows.Forms.Button btn_salvarConfig;
        private System.Windows.Forms.Button btn_fecharConfig;
        private System.Windows.Forms.PictureBox pctB_logo;
        private System.Windows.Forms.Button btn_folderWord;
        private System.Windows.Forms.TextBox txtB_wordDocument;
        private System.Windows.Forms.Label lbl_wordDocument;
    }
}