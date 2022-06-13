
namespace ProgFormularioEngenharia2
{
    partial class Frm_loading
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
            this.prgB_loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_contador = new System.Windows.Forms.Label();
            this.lbl_barra = new System.Windows.Forms.Label();
            this.lbl_contadorMaximo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgB_loading
            // 
            this.prgB_loading.Location = new System.Drawing.Point(14, 25);
            this.prgB_loading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prgB_loading.Name = "prgB_loading";
            this.prgB_loading.Size = new System.Drawing.Size(335, 35);
            this.prgB_loading.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(119, 80);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 45);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Done";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Location = new System.Drawing.Point(255, 92);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(0, 20);
            this.lbl_contador.TabIndex = 2;
            // 
            // lbl_barra
            // 
            this.lbl_barra.AutoSize = true;
            this.lbl_barra.Location = new System.Drawing.Point(290, 92);
            this.lbl_barra.Name = "lbl_barra";
            this.lbl_barra.Size = new System.Drawing.Size(13, 20);
            this.lbl_barra.TabIndex = 3;
            this.lbl_barra.Text = "/";
            // 
            // lbl_contadorMaximo
            // 
            this.lbl_contadorMaximo.AutoSize = true;
            this.lbl_contadorMaximo.Location = new System.Drawing.Point(309, 92);
            this.lbl_contadorMaximo.Name = "lbl_contadorMaximo";
            this.lbl_contadorMaximo.Size = new System.Drawing.Size(0, 20);
            this.lbl_contadorMaximo.TabIndex = 4;
            // 
            // Frm_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 133);
            this.Controls.Add(this.lbl_contadorMaximo);
            this.Controls.Add(this.lbl_barra);
            this.Controls.Add(this.lbl_contador);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.prgB_loading);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgB_loading;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_contador;
        private System.Windows.Forms.Label lbl_barra;
        private System.Windows.Forms.Label lbl_contadorMaximo;
    }
}