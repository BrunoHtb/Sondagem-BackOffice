
namespace ProgFormularioEngenharia2
{
    partial class Frm_MultiSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MultiSelect));
            this.dgv_multiselectSondagem = new System.Windows.Forms.DataGridView();
            this.id_MultiSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_MultiSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrega_MultiSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbB_filtro = new System.Windows.Forms.ComboBox();
            this.btn_mudarEntrega = new System.Windows.Forms.Button();
            this.btn_salvarEntrega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_multiselectSondagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_multiselectSondagem
            // 
            this.dgv_multiselectSondagem.AllowUserToAddRows = false;
            this.dgv_multiselectSondagem.AllowUserToDeleteRows = false;
            this.dgv_multiselectSondagem.AllowUserToResizeColumns = false;
            this.dgv_multiselectSondagem.AllowUserToResizeRows = false;
            this.dgv_multiselectSondagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_multiselectSondagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_multiselectSondagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_multiselectSondagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_multiselectSondagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_MultiSelect,
            this.nome_MultiSelect,
            this.entrega_MultiSelect});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_multiselectSondagem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_multiselectSondagem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_multiselectSondagem.GridColor = System.Drawing.Color.Black;
            this.dgv_multiselectSondagem.Location = new System.Drawing.Point(12, 104);
            this.dgv_multiselectSondagem.Name = "dgv_multiselectSondagem";
            this.dgv_multiselectSondagem.ReadOnly = true;
            this.dgv_multiselectSondagem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_multiselectSondagem.RowHeadersVisible = false;
            this.dgv_multiselectSondagem.RowHeadersWidth = 500;
            this.dgv_multiselectSondagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_multiselectSondagem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_multiselectSondagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_multiselectSondagem.Size = new System.Drawing.Size(345, 419);
            this.dgv_multiselectSondagem.TabIndex = 0;
            // 
            // id_MultiSelect
            // 
            this.id_MultiSelect.HeaderText = "Id";
            this.id_MultiSelect.Name = "id_MultiSelect";
            this.id_MultiSelect.ReadOnly = true;
            this.id_MultiSelect.Visible = false;
            // 
            // nome_MultiSelect
            // 
            this.nome_MultiSelect.HeaderText = "Nome";
            this.nome_MultiSelect.Name = "nome_MultiSelect";
            this.nome_MultiSelect.ReadOnly = true;
            // 
            // entrega_MultiSelect
            // 
            this.entrega_MultiSelect.HeaderText = "Entrega";
            this.entrega_MultiSelect.Name = "entrega_MultiSelect";
            this.entrega_MultiSelect.ReadOnly = true;
            // 
            // cmbB_filtro
            // 
            this.cmbB_filtro.FormattingEnabled = true;
            this.cmbB_filtro.Location = new System.Drawing.Point(12, 12);
            this.cmbB_filtro.Name = "cmbB_filtro";
            this.cmbB_filtro.Size = new System.Drawing.Size(161, 21);
            this.cmbB_filtro.TabIndex = 1;
            // 
            // btn_mudarEntrega
            // 
            this.btn_mudarEntrega.BackColor = System.Drawing.Color.White;
            this.btn_mudarEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_mudarEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mudarEntrega.ForeColor = System.Drawing.Color.Navy;
            this.btn_mudarEntrega.Location = new System.Drawing.Point(34, 51);
            this.btn_mudarEntrega.Name = "btn_mudarEntrega";
            this.btn_mudarEntrega.Size = new System.Drawing.Size(120, 34);
            this.btn_mudarEntrega.TabIndex = 2;
            this.btn_mudarEntrega.Text = "Mudar";
            this.btn_mudarEntrega.UseVisualStyleBackColor = false;
            this.btn_mudarEntrega.Click += new System.EventHandler(this.btn_mudarEntrega_Click);
            // 
            // btn_salvarEntrega
            // 
            this.btn_salvarEntrega.BackColor = System.Drawing.Color.Navy;
            this.btn_salvarEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarEntrega.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salvarEntrega.Location = new System.Drawing.Point(201, 12);
            this.btn_salvarEntrega.Name = "btn_salvarEntrega";
            this.btn_salvarEntrega.Size = new System.Drawing.Size(155, 73);
            this.btn_salvarEntrega.TabIndex = 3;
            this.btn_salvarEntrega.Text = "Salvar";
            this.btn_salvarEntrega.UseVisualStyleBackColor = false;
            this.btn_salvarEntrega.Click += new System.EventHandler(this.btn_salvarEntrega_Click);
            // 
            // Frm_MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(368, 535);
            this.Controls.Add(this.btn_salvarEntrega);
            this.Controls.Add(this.btn_mudarEntrega);
            this.Controls.Add(this.cmbB_filtro);
            this.Controls.Add(this.dgv_multiselectSondagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MultiSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_MultiSelect";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_MultiSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_multiselectSondagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_multiselectSondagem;
        public System.Windows.Forms.ComboBox cmbB_filtro;
        private System.Windows.Forms.Button btn_mudarEntrega;
        private System.Windows.Forms.Button btn_salvarEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_MultiSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_MultiSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrega_MultiSelect;
    }
}