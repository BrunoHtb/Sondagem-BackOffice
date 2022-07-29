using System.Drawing;
using System.Windows.Forms;

namespace ProgFormularioEngenharia2
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.dgv_sondagem = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_importarBD = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpB_planilha = new System.Windows.Forms.GroupBox();
            this.btn_multiSelect = new System.Windows.Forms.Button();
            this.cmbB_entregaFiltro = new System.Windows.Forms.ComboBox();
            this.lbl_entregaFiltro = new System.Windows.Forms.Label();
            this.lbl_quantidadeLinhas = new System.Windows.Forms.Label();
            this.lbl_linhaLote = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_legendaFiltro = new System.Windows.Forms.Label();
            this.cmbB_Lotes = new System.Windows.Forms.ComboBox();
            this.grpB_mapa = new System.Windows.Forms.GroupBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.grpB_foto = new System.Windows.Forms.GroupBox();
            this.lstView_listaFoto = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_importarPanilha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_organizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_foto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_planilha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.regionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_relatorioParcial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_relatorioCompleto = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátorioWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_dados = new System.Windows.Forms.TabControl();
            this.tbP_dados = new System.Windows.Forms.TabPage();
            this.grpB_dados = new System.Windows.Forms.GroupBox();
            this.lbl_regional = new System.Windows.Forms.Label();
            this.cmbB_regional = new System.Windows.Forms.ComboBox();
            this.lbl_entrega = new System.Windows.Forms.Label();
            this.cmbB_entrega = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.txtB_obs = new System.Windows.Forms.TextBox();
            this.txtB_status = new System.Windows.Forms.TextBox();
            this.txtB_espessura4 = new System.Windows.Forms.TextBox();
            this.txtB_espessura3 = new System.Windows.Forms.TextBox();
            this.txtB_espessura2 = new System.Windows.Forms.TextBox();
            this.txtB_espessura1 = new System.Windows.Forms.TextBox();
            this.txtB_camada4 = new System.Windows.Forms.TextBox();
            this.txtB_camada3 = new System.Windows.Forms.TextBox();
            this.txtB_camada2 = new System.Windows.Forms.TextBox();
            this.txtB_camada1 = new System.Windows.Forms.TextBox();
            this.txtB_area = new System.Windows.Forms.TextBox();
            this.txtB_lote = new System.Windows.Forms.TextBox();
            this.txtB_trecho = new System.Windows.Forms.TextBox();
            this.txtB_metro = new System.Windows.Forms.TextBox();
            this.txtB_km = new System.Windows.Forms.TextBox();
            this.txtB_rodovia = new System.Windows.Forms.TextBox();
            this.txtB_longitude = new System.Windows.Forms.TextBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_espessura4 = new System.Windows.Forms.Label();
            this.lbl_espessura3 = new System.Windows.Forms.Label();
            this.lbl_espessura2 = new System.Windows.Forms.Label();
            this.lbl_espessura1 = new System.Windows.Forms.Label();
            this.lbl_trecho = new System.Windows.Forms.Label();
            this.lbl_camada4 = new System.Windows.Forms.Label();
            this.lbl_metro = new System.Windows.Forms.Label();
            this.lbl_camada3 = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_camada1 = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_camada2 = new System.Windows.Forms.Label();
            this.lbl_rodovia = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.lbl_lote = new System.Windows.Forms.Label();
            this.txtB_latitude = new System.Windows.Forms.TextBox();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.txtB_nameProj = new System.Windows.Forms.TextBox();
            this.lbl_nomeProjeto = new System.Windows.Forms.Label();
            this.tbp_foto = new System.Windows.Forms.TabPage();
            this.grpB_fotosEditarNome = new System.Windows.Forms.GroupBox();
            this.btn_salvar1 = new System.Windows.Forms.Button();
            this.lbl_foto1 = new System.Windows.Forms.Label();
            this.txtB_foto10 = new System.Windows.Forms.TextBox();
            this.lbl_foto3 = new System.Windows.Forms.Label();
            this.txtB_foto9 = new System.Windows.Forms.TextBox();
            this.lbl_foto5 = new System.Windows.Forms.Label();
            this.txtB_foto8 = new System.Windows.Forms.TextBox();
            this.lbl_foto7 = new System.Windows.Forms.Label();
            this.txtB_foto7 = new System.Windows.Forms.TextBox();
            this.lbl_foto9 = new System.Windows.Forms.Label();
            this.txtB_foto6 = new System.Windows.Forms.TextBox();
            this.lbl_foto2 = new System.Windows.Forms.Label();
            this.txtB_foto5 = new System.Windows.Forms.TextBox();
            this.lbl_foto4 = new System.Windows.Forms.Label();
            this.txtB_foto4 = new System.Windows.Forms.TextBox();
            this.lbl_foto6 = new System.Windows.Forms.Label();
            this.txtB_foto3 = new System.Windows.Forms.TextBox();
            this.lbl_foto8 = new System.Windows.Forms.Label();
            this.txtB_foto2 = new System.Windows.Forms.TextBox();
            this.lbl_foto10 = new System.Windows.Forms.Label();
            this.txtB_foto1 = new System.Windows.Forms.TextBox();
            this.tbP_entrega = new System.Windows.Forms.TabPage();
            this.grpB_entrega = new System.Windows.Forms.GroupBox();
            this.btn_salvar2 = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_addNovaEntrega = new System.Windows.Forms.Button();
            this.txtB_entrega = new System.Windows.Forms.TextBox();
            this.pnl_dados = new System.Windows.Forms.Panel();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNomeFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodovia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trecho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camada3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camada4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espessura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espessura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espessura3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espessura4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relátorioPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sondagem)).BeginInit();
            this.grpB_planilha.SuspendLayout();
            this.grpB_mapa.SuspendLayout();
            this.grpB_foto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbc_dados.SuspendLayout();
            this.tbP_dados.SuspendLayout();
            this.grpB_dados.SuspendLayout();
            this.tbp_foto.SuspendLayout();
            this.grpB_fotosEditarNome.SuspendLayout();
            this.tbP_entrega.SuspendLayout();
            this.grpB_entrega.SuspendLayout();
            this.pnl_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sondagem
            // 
            this.dgv_sondagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sondagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_sondagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_sondagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sondagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.coordX,
            this.coordY,
            this.rodovia,
            this.km,
            this.metro,
            this.trecho,
            this.lote,
            this.area,
            this.camada1,
            this.camada2,
            this.camada3,
            this.camada4,
            this.espessura1,
            this.espessura2,
            this.espessura3,
            this.espessura4,
            this.status,
            this.observacao,
            this.foto,
            this.entrega,
            this.regional,
            this.dataCadastro});
            this.dgv_sondagem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_sondagem.Location = new System.Drawing.Point(11, 38);
            this.dgv_sondagem.MultiSelect = false;
            this.dgv_sondagem.Name = "dgv_sondagem";
            this.dgv_sondagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sondagem.Size = new System.Drawing.Size(821, 226);
            this.dgv_sondagem.TabIndex = 1;
            this.dgv_sondagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dgv_sondagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_sondagem_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Orange;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Editar.Location = new System.Drawing.Point(30, 27);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(137, 54);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btnEditarPlanilha_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.White;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Deletar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.Color.Red;
            this.btn_Deletar.Location = new System.Drawing.Point(208, 27);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(131, 54);
            this.btn_Deletar.TabIndex = 3;
            this.btn_Deletar.Text = "DELETAR";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btn_importarBD
            // 
            this.btn_importarBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_importarBD.BackColor = System.Drawing.Color.Ivory;
            this.btn_importarBD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_importarBD.ForeColor = System.Drawing.Color.Navy;
            this.btn_importarBD.Image = ((System.Drawing.Image)(resources.GetObject("btn_importarBD.Image")));
            this.btn_importarBD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_importarBD.Location = new System.Drawing.Point(1156, 27);
            this.btn_importarBD.Name = "btn_importarBD";
            this.btn_importarBD.Size = new System.Drawing.Size(129, 54);
            this.btn_importarBD.TabIndex = 4;
            this.btn_importarBD.Text = "  Importar";
            this.btn_importarBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_importarBD.UseVisualStyleBackColor = false;
            this.btn_importarBD.Click += new System.EventHandler(this.btnImportatBD_Click);
            // 
            // grpB_planilha
            // 
            this.grpB_planilha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpB_planilha.AutoSize = true;
            this.grpB_planilha.BackColor = System.Drawing.Color.White;
            this.grpB_planilha.Controls.Add(this.btn_multiSelect);
            this.grpB_planilha.Controls.Add(this.cmbB_entregaFiltro);
            this.grpB_planilha.Controls.Add(this.lbl_entregaFiltro);
            this.grpB_planilha.Controls.Add(this.lbl_quantidadeLinhas);
            this.grpB_planilha.Controls.Add(this.lbl_linhaLote);
            this.grpB_planilha.Controls.Add(this.btn_search);
            this.grpB_planilha.Controls.Add(this.lbl_legendaFiltro);
            this.grpB_planilha.Controls.Add(this.cmbB_Lotes);
            this.grpB_planilha.Controls.Add(this.dgv_sondagem);
            this.grpB_planilha.Location = new System.Drawing.Point(490, 87);
            this.grpB_planilha.Name = "grpB_planilha";
            this.grpB_planilha.Size = new System.Drawing.Size(861, 789);
            this.grpB_planilha.TabIndex = 8;
            this.grpB_planilha.TabStop = false;
            // 
            // btn_multiSelect
            // 
            this.btn_multiSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiSelect.Location = new System.Drawing.Point(569, 10);
            this.btn_multiSelect.Name = "btn_multiSelect";
            this.btn_multiSelect.Size = new System.Drawing.Size(75, 23);
            this.btn_multiSelect.TabIndex = 0;
            this.btn_multiSelect.Text = "Multiseleção";
            this.btn_multiSelect.Click += new System.EventHandler(this.btn_multiSelect_Click_1);
            // 
            // cmbB_entregaFiltro
            // 
            this.cmbB_entregaFiltro.FormattingEnabled = true;
            this.cmbB_entregaFiltro.Items.AddRange(new object[] {
            "*"});
            this.cmbB_entregaFiltro.Location = new System.Drawing.Point(321, 11);
            this.cmbB_entregaFiltro.Name = "cmbB_entregaFiltro";
            this.cmbB_entregaFiltro.Size = new System.Drawing.Size(136, 21);
            this.cmbB_entregaFiltro.Sorted = true;
            this.cmbB_entregaFiltro.TabIndex = 8;
            // 
            // lbl_entregaFiltro
            // 
            this.lbl_entregaFiltro.AutoSize = true;
            this.lbl_entregaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_entregaFiltro.Location = new System.Drawing.Point(244, 11);
            this.lbl_entregaFiltro.Name = "lbl_entregaFiltro";
            this.lbl_entregaFiltro.Size = new System.Drawing.Size(61, 16);
            this.lbl_entregaFiltro.TabIndex = 7;
            this.lbl_entregaFiltro.Text = "Entrega";
            // 
            // lbl_quantidadeLinhas
            // 
            this.lbl_quantidadeLinhas.AutoSize = true;
            this.lbl_quantidadeLinhas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidadeLinhas.Location = new System.Drawing.Point(678, 15);
            this.lbl_quantidadeLinhas.Name = "lbl_quantidadeLinhas";
            this.lbl_quantidadeLinhas.Size = new System.Drawing.Size(59, 18);
            this.lbl_quantidadeLinhas.TabIndex = 6;
            this.lbl_quantidadeLinhas.Text = "Linhas:";
            // 
            // lbl_linhaLote
            // 
            this.lbl_linhaLote.AutoSize = true;
            this.lbl_linhaLote.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_linhaLote.Location = new System.Drawing.Point(743, 11);
            this.lbl_linhaLote.Name = "lbl_linhaLote";
            this.lbl_linhaLote.Size = new System.Drawing.Size(0, 23);
            this.lbl_linhaLote.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(478, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_legendaFiltro
            // 
            this.lbl_legendaFiltro.AutoSize = true;
            this.lbl_legendaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_legendaFiltro.Location = new System.Drawing.Point(14, 11);
            this.lbl_legendaFiltro.Name = "lbl_legendaFiltro";
            this.lbl_legendaFiltro.Size = new System.Drawing.Size(37, 16);
            this.lbl_legendaFiltro.TabIndex = 3;
            this.lbl_legendaFiltro.Text = "Lote";
            // 
            // cmbB_Lotes
            // 
            this.cmbB_Lotes.FormattingEnabled = true;
            this.cmbB_Lotes.Items.AddRange(new object[] {
            "*"});
            this.cmbB_Lotes.Location = new System.Drawing.Point(58, 11);
            this.cmbB_Lotes.Name = "cmbB_Lotes";
            this.cmbB_Lotes.Size = new System.Drawing.Size(136, 21);
            this.cmbB_Lotes.Sorted = true;
            this.cmbB_Lotes.TabIndex = 2;
            // 
            // grpB_mapa
            // 
            this.grpB_mapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpB_mapa.BackColor = System.Drawing.Color.White;
            this.grpB_mapa.Controls.Add(this.gMap);
            this.grpB_mapa.Location = new System.Drawing.Point(490, 372);
            this.grpB_mapa.Name = "grpB_mapa";
            this.grpB_mapa.Size = new System.Drawing.Size(612, 486);
            this.grpB_mapa.TabIndex = 9;
            this.grpB_mapa.TabStop = false;
            this.grpB_mapa.Text = "Mapa";
            // 
            // gMap
            // 
            this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMap.AutoScroll = true;
            this.gMap.AutoScrollMargin = new System.Drawing.Size(500, 365);
            this.gMap.AutoSize = true;
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(8, 19);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(598, 458);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 2D;
            // 
            // grpB_foto
            // 
            this.grpB_foto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpB_foto.BackColor = System.Drawing.Color.White;
            this.grpB_foto.Controls.Add(this.lstView_listaFoto);
            this.grpB_foto.Location = new System.Drawing.Point(1102, 372);
            this.grpB_foto.Name = "grpB_foto";
            this.grpB_foto.Size = new System.Drawing.Size(249, 486);
            this.grpB_foto.TabIndex = 12;
            this.grpB_foto.TabStop = false;
            this.grpB_foto.Text = "Foto";
            // 
            // lstView_listaFoto
            // 
            this.lstView_listaFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView_listaFoto.HideSelection = false;
            this.lstView_listaFoto.Location = new System.Drawing.Point(6, 19);
            this.lstView_listaFoto.Name = "lstView_listaFoto";
            this.lstView_listaFoto.Size = new System.Drawing.Size(226, 458);
            this.lstView_listaFoto.TabIndex = 12;
            this.lstView_listaFoto.UseCompatibleStateImageBehavior = false;
            this.lstView_listaFoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstView_listaFoto_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecionarToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.toolstrip_relatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_importarPanilha,
            this.toolstrip_organizar,
            this.toolStripSeparator1,
            this.regionalToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.dataNomeFotoToolStripMenuItem,
            this.kMToolStripMenuItem});
            this.selecionarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            // 
            // toolstrip_importarPanilha
            // 
            this.toolstrip_importarPanilha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstrip_importarPanilha.Name = "toolstrip_importarPanilha";
            this.toolstrip_importarPanilha.Size = new System.Drawing.Size(180, 22);
            this.toolstrip_importarPanilha.Text = "Importar Panilha";
            this.toolstrip_importarPanilha.Click += new System.EventHandler(this.importarPanilhaToolStripMenuItem_Click);
            // 
            // toolstrip_organizar
            // 
            this.toolstrip_organizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_foto,
            this.toolstrip_planilha});
            this.toolstrip_organizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstrip_organizar.Name = "toolstrip_organizar";
            this.toolstrip_organizar.Size = new System.Drawing.Size(180, 22);
            this.toolstrip_organizar.Text = "Organizar";
            // 
            // toolstrip_foto
            // 
            this.toolstrip_foto.Name = "toolstrip_foto";
            this.toolstrip_foto.Size = new System.Drawing.Size(119, 22);
            this.toolstrip_foto.Text = "Foto";
            this.toolstrip_foto.Click += new System.EventHandler(this.toolstrip_fotoOrganizar_Click);
            // 
            // toolstrip_planilha
            // 
            this.toolstrip_planilha.Name = "toolstrip_planilha";
            this.toolstrip_planilha.Size = new System.Drawing.Size(119, 22);
            this.toolstrip_planilha.Text = "Planilha";
            this.toolstrip_planilha.Click += new System.EventHandler(this.toolstrip_planilhaOrganizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // regionalToolStripMenuItem
            // 
            this.regionalToolStripMenuItem.Name = "regionalToolStripMenuItem";
            this.regionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regionalToolStripMenuItem.Text = "Regional";
            this.regionalToolStripMenuItem.Visible = false;
            this.regionalToolStripMenuItem.Click += new System.EventHandler(this.regionalToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoRedeToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.configuraçãoToolStripMenuItem.Text = "Opção";
            // 
            // configuraçãoRedeToolStripMenuItem
            // 
            this.configuraçãoRedeToolStripMenuItem.AccessibleDescription = "";
            this.configuraçãoRedeToolStripMenuItem.Name = "configuraçãoRedeToolStripMenuItem";
            this.configuraçãoRedeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.configuraçãoRedeToolStripMenuItem.Text = "Configuração";
            this.configuraçãoRedeToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoRedeToolStripMenuItem_Click);
            // 
            // toolstrip_relatorio
            // 
            this.toolstrip_relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_relatorioParcial,
            this.toolstrip_relatorioCompleto,
            this.reToolStripMenuItem,
            this.relátorioWORDToolStripMenuItem,
            this.relátorioPDFToolStripMenuItem});
            this.toolstrip_relatorio.Enabled = false;
            this.toolstrip_relatorio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolstrip_relatorio.Name = "toolstrip_relatorio";
            this.toolstrip_relatorio.Size = new System.Drawing.Size(77, 20);
            this.toolstrip_relatorio.Text = "Relatório";
            // 
            // toolstrip_relatorioParcial
            // 
            this.toolstrip_relatorioParcial.Name = "toolstrip_relatorioParcial";
            this.toolstrip_relatorioParcial.Size = new System.Drawing.Size(203, 22);
            this.toolstrip_relatorioParcial.Text = "Relátorio Parcial";
            this.toolstrip_relatorioParcial.Click += new System.EventHandler(this.toolstrip_relatorioParcial_Click);
            // 
            // toolstrip_relatorioCompleto
            // 
            this.toolstrip_relatorioCompleto.Name = "toolstrip_relatorioCompleto";
            this.toolstrip_relatorioCompleto.Size = new System.Drawing.Size(203, 22);
            this.toolstrip_relatorioCompleto.Text = "Relátorio Completo";
            this.toolstrip_relatorioCompleto.Click += new System.EventHandler(this.toolstrip_relatorioCompleto_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reToolStripMenuItem.Text = "Relátorio Sem Fotos";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // relátorioWORDToolStripMenuItem
            // 
            this.relátorioWORDToolStripMenuItem.Name = "relátorioWORDToolStripMenuItem";
            this.relátorioWORDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.relátorioWORDToolStripMenuItem.Text = "Relátorio WORD";
            this.relátorioWORDToolStripMenuItem.Click += new System.EventHandler(this.relátorioWORDToolStripMenuItem_Click);
            // 
            // tbc_dados
            // 
            this.tbc_dados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbc_dados.Controls.Add(this.tbP_dados);
            this.tbc_dados.Controls.Add(this.tbp_foto);
            this.tbc_dados.Controls.Add(this.tbP_entrega);
            this.tbc_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_dados.Location = new System.Drawing.Point(0, 3);
            this.tbc_dados.Name = "tbc_dados";
            this.tbc_dados.SelectedIndex = 0;
            this.tbc_dados.Size = new System.Drawing.Size(490, 786);
            this.tbc_dados.TabIndex = 22;
            // 
            // tbP_dados
            // 
            this.tbP_dados.AutoScroll = true;
            this.tbP_dados.Controls.Add(this.grpB_dados);
            this.tbP_dados.Location = new System.Drawing.Point(4, 22);
            this.tbP_dados.Name = "tbP_dados";
            this.tbP_dados.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_dados.Size = new System.Drawing.Size(482, 760);
            this.tbP_dados.TabIndex = 0;
            this.tbP_dados.Text = "Dados";
            this.tbP_dados.UseVisualStyleBackColor = true;
            // 
            // grpB_dados
            // 
            this.grpB_dados.AutoSize = true;
            this.grpB_dados.BackColor = System.Drawing.Color.White;
            this.grpB_dados.Controls.Add(this.lbl_regional);
            this.grpB_dados.Controls.Add(this.cmbB_regional);
            this.grpB_dados.Controls.Add(this.lbl_entrega);
            this.grpB_dados.Controls.Add(this.cmbB_entrega);
            this.grpB_dados.Controls.Add(this.btn_salvar);
            this.grpB_dados.Controls.Add(this.pnl_button);
            this.grpB_dados.Controls.Add(this.txtB_obs);
            this.grpB_dados.Controls.Add(this.txtB_status);
            this.grpB_dados.Controls.Add(this.txtB_espessura4);
            this.grpB_dados.Controls.Add(this.txtB_espessura3);
            this.grpB_dados.Controls.Add(this.txtB_espessura2);
            this.grpB_dados.Controls.Add(this.txtB_espessura1);
            this.grpB_dados.Controls.Add(this.txtB_camada4);
            this.grpB_dados.Controls.Add(this.txtB_camada3);
            this.grpB_dados.Controls.Add(this.txtB_camada2);
            this.grpB_dados.Controls.Add(this.txtB_camada1);
            this.grpB_dados.Controls.Add(this.txtB_area);
            this.grpB_dados.Controls.Add(this.txtB_lote);
            this.grpB_dados.Controls.Add(this.txtB_trecho);
            this.grpB_dados.Controls.Add(this.txtB_metro);
            this.grpB_dados.Controls.Add(this.txtB_km);
            this.grpB_dados.Controls.Add(this.txtB_rodovia);
            this.grpB_dados.Controls.Add(this.txtB_longitude);
            this.grpB_dados.Controls.Add(this.lbl_obs);
            this.grpB_dados.Controls.Add(this.lbl_status);
            this.grpB_dados.Controls.Add(this.lbl_espessura4);
            this.grpB_dados.Controls.Add(this.lbl_espessura3);
            this.grpB_dados.Controls.Add(this.lbl_espessura2);
            this.grpB_dados.Controls.Add(this.lbl_espessura1);
            this.grpB_dados.Controls.Add(this.lbl_trecho);
            this.grpB_dados.Controls.Add(this.lbl_camada4);
            this.grpB_dados.Controls.Add(this.lbl_metro);
            this.grpB_dados.Controls.Add(this.lbl_camada3);
            this.grpB_dados.Controls.Add(this.lbl_km);
            this.grpB_dados.Controls.Add(this.lbl_camada1);
            this.grpB_dados.Controls.Add(this.lbl_area);
            this.grpB_dados.Controls.Add(this.lbl_camada2);
            this.grpB_dados.Controls.Add(this.lbl_rodovia);
            this.grpB_dados.Controls.Add(this.lbl_longitude);
            this.grpB_dados.Controls.Add(this.lbl_lote);
            this.grpB_dados.Controls.Add(this.txtB_latitude);
            this.grpB_dados.Controls.Add(this.lbl_latitude);
            this.grpB_dados.Controls.Add(this.txtB_nameProj);
            this.grpB_dados.Controls.Add(this.lbl_nomeProjeto);
            this.grpB_dados.Enabled = false;
            this.grpB_dados.Location = new System.Drawing.Point(0, -14);
            this.grpB_dados.Name = "grpB_dados";
            this.grpB_dados.Size = new System.Drawing.Size(465, 1008);
            this.grpB_dados.TabIndex = 7;
            this.grpB_dados.TabStop = false;
            // 
            // lbl_regional
            // 
            this.lbl_regional.AutoSize = true;
            this.lbl_regional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_regional.Location = new System.Drawing.Point(263, 32);
            this.lbl_regional.Name = "lbl_regional";
            this.lbl_regional.Size = new System.Drawing.Size(70, 16);
            this.lbl_regional.TabIndex = 45;
            this.lbl_regional.Text = "Regional";
            // 
            // cmbB_regional
            // 
            this.cmbB_regional.FormattingEnabled = true;
            this.cmbB_regional.Items.AddRange(new object[] {
            "Regional Campos Gerais",
            "Regional Leste"});
            this.cmbB_regional.Location = new System.Drawing.Point(263, 48);
            this.cmbB_regional.Name = "cmbB_regional";
            this.cmbB_regional.Size = new System.Drawing.Size(179, 21);
            this.cmbB_regional.TabIndex = 44;
            // 
            // lbl_entrega
            // 
            this.lbl_entrega.AutoSize = true;
            this.lbl_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_entrega.ForeColor = System.Drawing.Color.Navy;
            this.lbl_entrega.Location = new System.Drawing.Point(23, 32);
            this.lbl_entrega.Name = "lbl_entrega";
            this.lbl_entrega.Size = new System.Drawing.Size(61, 16);
            this.lbl_entrega.TabIndex = 43;
            this.lbl_entrega.Text = "Entrega";
            // 
            // cmbB_entrega
            // 
            this.cmbB_entrega.FormattingEnabled = true;
            this.cmbB_entrega.Location = new System.Drawing.Point(26, 48);
            this.cmbB_entrega.Name = "cmbB_entrega";
            this.cmbB_entrega.Size = new System.Drawing.Size(179, 21);
            this.cmbB_entrega.Sorted = true;
            this.cmbB_entrega.TabIndex = 0;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(146, 765);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(189, 68);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pnl_button
            // 
            this.pnl_button.AutoScroll = true;
            this.pnl_button.Location = new System.Drawing.Point(151, 894);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(184, 88);
            this.pnl_button.TabIndex = 21;
            // 
            // txtB_obs
            // 
            this.txtB_obs.Location = new System.Drawing.Point(26, 671);
            this.txtB_obs.Multiline = true;
            this.txtB_obs.Name = "txtB_obs";
            this.txtB_obs.Size = new System.Drawing.Size(423, 69);
            this.txtB_obs.TabIndex = 9;
            // 
            // txtB_status
            // 
            this.txtB_status.Location = new System.Drawing.Point(263, 104);
            this.txtB_status.Name = "txtB_status";
            this.txtB_status.Size = new System.Drawing.Size(179, 20);
            this.txtB_status.TabIndex = 10;
            // 
            // txtB_espessura4
            // 
            this.txtB_espessura4.Location = new System.Drawing.Point(263, 590);
            this.txtB_espessura4.Name = "txtB_espessura4";
            this.txtB_espessura4.Size = new System.Drawing.Size(179, 20);
            this.txtB_espessura4.TabIndex = 11;
            // 
            // txtB_espessura3
            // 
            this.txtB_espessura3.Location = new System.Drawing.Point(263, 517);
            this.txtB_espessura3.Name = "txtB_espessura3";
            this.txtB_espessura3.Size = new System.Drawing.Size(179, 20);
            this.txtB_espessura3.TabIndex = 12;
            // 
            // txtB_espessura2
            // 
            this.txtB_espessura2.Location = new System.Drawing.Point(263, 448);
            this.txtB_espessura2.Name = "txtB_espessura2";
            this.txtB_espessura2.Size = new System.Drawing.Size(179, 20);
            this.txtB_espessura2.TabIndex = 13;
            // 
            // txtB_espessura1
            // 
            this.txtB_espessura1.Location = new System.Drawing.Point(263, 379);
            this.txtB_espessura1.Name = "txtB_espessura1";
            this.txtB_espessura1.Size = new System.Drawing.Size(179, 20);
            this.txtB_espessura1.TabIndex = 14;
            // 
            // txtB_camada4
            // 
            this.txtB_camada4.Location = new System.Drawing.Point(26, 589);
            this.txtB_camada4.Multiline = true;
            this.txtB_camada4.Name = "txtB_camada4";
            this.txtB_camada4.Size = new System.Drawing.Size(179, 49);
            this.txtB_camada4.TabIndex = 10;
            // 
            // txtB_camada3
            // 
            this.txtB_camada3.Location = new System.Drawing.Point(26, 517);
            this.txtB_camada3.Multiline = true;
            this.txtB_camada3.Name = "txtB_camada3";
            this.txtB_camada3.Size = new System.Drawing.Size(179, 49);
            this.txtB_camada3.TabIndex = 11;
            // 
            // txtB_camada2
            // 
            this.txtB_camada2.Location = new System.Drawing.Point(26, 448);
            this.txtB_camada2.Multiline = true;
            this.txtB_camada2.Name = "txtB_camada2";
            this.txtB_camada2.Size = new System.Drawing.Size(179, 49);
            this.txtB_camada2.TabIndex = 12;
            // 
            // txtB_camada1
            // 
            this.txtB_camada1.Location = new System.Drawing.Point(26, 379);
            this.txtB_camada1.Multiline = true;
            this.txtB_camada1.Name = "txtB_camada1";
            this.txtB_camada1.Size = new System.Drawing.Size(179, 49);
            this.txtB_camada1.TabIndex = 13;
            // 
            // txtB_area
            // 
            this.txtB_area.Location = new System.Drawing.Point(263, 326);
            this.txtB_area.Name = "txtB_area";
            this.txtB_area.Size = new System.Drawing.Size(179, 20);
            this.txtB_area.TabIndex = 14;
            // 
            // txtB_lote
            // 
            this.txtB_lote.Location = new System.Drawing.Point(26, 325);
            this.txtB_lote.Name = "txtB_lote";
            this.txtB_lote.Size = new System.Drawing.Size(179, 20);
            this.txtB_lote.TabIndex = 15;
            // 
            // txtB_trecho
            // 
            this.txtB_trecho.Location = new System.Drawing.Point(263, 265);
            this.txtB_trecho.Name = "txtB_trecho";
            this.txtB_trecho.Size = new System.Drawing.Size(179, 20);
            this.txtB_trecho.TabIndex = 16;
            // 
            // txtB_metro
            // 
            this.txtB_metro.Location = new System.Drawing.Point(26, 265);
            this.txtB_metro.Name = "txtB_metro";
            this.txtB_metro.Size = new System.Drawing.Size(179, 20);
            this.txtB_metro.TabIndex = 17;
            // 
            // txtB_km
            // 
            this.txtB_km.Location = new System.Drawing.Point(263, 217);
            this.txtB_km.Name = "txtB_km";
            this.txtB_km.Size = new System.Drawing.Size(179, 20);
            this.txtB_km.TabIndex = 18;
            // 
            // txtB_rodovia
            // 
            this.txtB_rodovia.Location = new System.Drawing.Point(26, 214);
            this.txtB_rodovia.Name = "txtB_rodovia";
            this.txtB_rodovia.Size = new System.Drawing.Size(179, 20);
            this.txtB_rodovia.TabIndex = 19;
            // 
            // txtB_longitude
            // 
            this.txtB_longitude.Location = new System.Drawing.Point(263, 162);
            this.txtB_longitude.Name = "txtB_longitude";
            this.txtB_longitude.Size = new System.Drawing.Size(179, 20);
            this.txtB_longitude.TabIndex = 20;
            // 
            // lbl_obs
            // 
            this.lbl_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_obs.Location = new System.Drawing.Point(23, 652);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(100, 23);
            this.lbl_obs.TabIndex = 18;
            this.lbl_obs.Text = "Obervação";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_status.Location = new System.Drawing.Point(260, 90);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 23);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Status";
            // 
            // lbl_espessura4
            // 
            this.lbl_espessura4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_espessura4.Location = new System.Drawing.Point(263, 574);
            this.lbl_espessura4.Name = "lbl_espessura4";
            this.lbl_espessura4.Size = new System.Drawing.Size(100, 23);
            this.lbl_espessura4.TabIndex = 16;
            this.lbl_espessura4.Text = "Espessura 4";
            // 
            // lbl_espessura3
            // 
            this.lbl_espessura3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_espessura3.Location = new System.Drawing.Point(260, 501);
            this.lbl_espessura3.Name = "lbl_espessura3";
            this.lbl_espessura3.Size = new System.Drawing.Size(100, 23);
            this.lbl_espessura3.TabIndex = 17;
            this.lbl_espessura3.Text = "Espessura 3";
            // 
            // lbl_espessura2
            // 
            this.lbl_espessura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_espessura2.Location = new System.Drawing.Point(263, 432);
            this.lbl_espessura2.Name = "lbl_espessura2";
            this.lbl_espessura2.Size = new System.Drawing.Size(100, 23);
            this.lbl_espessura2.TabIndex = 18;
            this.lbl_espessura2.Text = "Espessura 2";
            // 
            // lbl_espessura1
            // 
            this.lbl_espessura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_espessura1.Location = new System.Drawing.Point(260, 363);
            this.lbl_espessura1.Name = "lbl_espessura1";
            this.lbl_espessura1.Size = new System.Drawing.Size(100, 23);
            this.lbl_espessura1.TabIndex = 15;
            this.lbl_espessura1.Text = "Espessura 1";
            // 
            // lbl_trecho
            // 
            this.lbl_trecho.AutoSize = true;
            this.lbl_trecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_trecho.Location = new System.Drawing.Point(263, 249);
            this.lbl_trecho.Name = "lbl_trecho";
            this.lbl_trecho.Size = new System.Drawing.Size(56, 16);
            this.lbl_trecho.TabIndex = 14;
            this.lbl_trecho.Text = "Trecho";
            // 
            // lbl_camada4
            // 
            this.lbl_camada4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_camada4.Location = new System.Drawing.Point(23, 574);
            this.lbl_camada4.Name = "lbl_camada4";
            this.lbl_camada4.Size = new System.Drawing.Size(100, 23);
            this.lbl_camada4.TabIndex = 16;
            this.lbl_camada4.Text = "Camada 4";
            // 
            // lbl_metro
            // 
            this.lbl_metro.AutoSize = true;
            this.lbl_metro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_metro.Location = new System.Drawing.Point(23, 249);
            this.lbl_metro.Name = "lbl_metro";
            this.lbl_metro.Size = new System.Drawing.Size(46, 16);
            this.lbl_metro.TabIndex = 13;
            this.lbl_metro.Text = "Metro";
            // 
            // lbl_camada3
            // 
            this.lbl_camada3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_camada3.Location = new System.Drawing.Point(23, 501);
            this.lbl_camada3.Name = "lbl_camada3";
            this.lbl_camada3.Size = new System.Drawing.Size(100, 23);
            this.lbl_camada3.TabIndex = 17;
            this.lbl_camada3.Text = "Camada 3";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_km.Location = new System.Drawing.Point(263, 198);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(28, 16);
            this.lbl_km.TabIndex = 12;
            this.lbl_km.Text = "KM";
            // 
            // lbl_camada1
            // 
            this.lbl_camada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_camada1.Location = new System.Drawing.Point(23, 363);
            this.lbl_camada1.Name = "lbl_camada1";
            this.lbl_camada1.Size = new System.Drawing.Size(100, 23);
            this.lbl_camada1.TabIndex = 20;
            this.lbl_camada1.Text = "Camada 1";
            // 
            // lbl_area
            // 
            this.lbl_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_area.Location = new System.Drawing.Point(263, 310);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(100, 23);
            this.lbl_area.TabIndex = 19;
            this.lbl_area.Text = "Área";
            // 
            // lbl_camada2
            // 
            this.lbl_camada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_camada2.Location = new System.Drawing.Point(23, 432);
            this.lbl_camada2.Name = "lbl_camada2";
            this.lbl_camada2.Size = new System.Drawing.Size(100, 23);
            this.lbl_camada2.TabIndex = 18;
            this.lbl_camada2.Text = "Camada 2";
            // 
            // lbl_rodovia
            // 
            this.lbl_rodovia.AutoSize = true;
            this.lbl_rodovia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_rodovia.Location = new System.Drawing.Point(23, 198);
            this.lbl_rodovia.Name = "lbl_rodovia";
            this.lbl_rodovia.Size = new System.Drawing.Size(66, 16);
            this.lbl_rodovia.TabIndex = 11;
            this.lbl_rodovia.Text = "Rodovia";
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_longitude.Location = new System.Drawing.Point(263, 146);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(75, 16);
            this.lbl_longitude.TabIndex = 10;
            this.lbl_longitude.Text = "Longitude";
            // 
            // lbl_lote
            // 
            this.lbl_lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_lote.Location = new System.Drawing.Point(23, 310);
            this.lbl_lote.Name = "lbl_lote";
            this.lbl_lote.Size = new System.Drawing.Size(100, 23);
            this.lbl_lote.TabIndex = 0;
            this.lbl_lote.Text = "Lote";
            // 
            // txtB_latitude
            // 
            this.txtB_latitude.Location = new System.Drawing.Point(26, 162);
            this.txtB_latitude.Name = "txtB_latitude";
            this.txtB_latitude.Size = new System.Drawing.Size(179, 20);
            this.txtB_latitude.TabIndex = 8;
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_latitude.Location = new System.Drawing.Point(23, 146);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(62, 16);
            this.lbl_latitude.TabIndex = 7;
            this.lbl_latitude.Text = "Latitude";
            // 
            // txtB_nameProj
            // 
            this.txtB_nameProj.Location = new System.Drawing.Point(26, 104);
            this.txtB_nameProj.Name = "txtB_nameProj";
            this.txtB_nameProj.Size = new System.Drawing.Size(179, 20);
            this.txtB_nameProj.TabIndex = 6;
            // 
            // lbl_nomeProjeto
            // 
            this.lbl_nomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeProjeto.Location = new System.Drawing.Point(23, 90);
            this.lbl_nomeProjeto.Name = "lbl_nomeProjeto";
            this.lbl_nomeProjeto.Size = new System.Drawing.Size(63, 22);
            this.lbl_nomeProjeto.TabIndex = 5;
            this.lbl_nomeProjeto.Text = "Nome";
            // 
            // tbp_foto
            // 
            this.tbp_foto.AutoScroll = true;
            this.tbp_foto.Controls.Add(this.grpB_fotosEditarNome);
            this.tbp_foto.Location = new System.Drawing.Point(4, 22);
            this.tbp_foto.Name = "tbp_foto";
            this.tbp_foto.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_foto.Size = new System.Drawing.Size(482, 760);
            this.tbp_foto.TabIndex = 1;
            this.tbp_foto.Text = "Fotos";
            this.tbp_foto.UseVisualStyleBackColor = true;
            // 
            // grpB_fotosEditarNome
            // 
            this.grpB_fotosEditarNome.Controls.Add(this.btn_salvar1);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto1);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto10);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto3);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto9);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto5);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto8);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto7);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto7);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto9);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto6);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto2);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto5);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto4);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto4);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto6);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto3);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto8);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto2);
            this.grpB_fotosEditarNome.Controls.Add(this.lbl_foto10);
            this.grpB_fotosEditarNome.Controls.Add(this.txtB_foto1);
            this.grpB_fotosEditarNome.Enabled = false;
            this.grpB_fotosEditarNome.Location = new System.Drawing.Point(0, -11);
            this.grpB_fotosEditarNome.Name = "grpB_fotosEditarNome";
            this.grpB_fotosEditarNome.Size = new System.Drawing.Size(475, 753);
            this.grpB_fotosEditarNome.TabIndex = 40;
            this.grpB_fotosEditarNome.TabStop = false;
            // 
            // btn_salvar1
            // 
            this.btn_salvar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_salvar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar1.ForeColor = System.Drawing.Color.White;
            this.btn_salvar1.Location = new System.Drawing.Point(137, 447);
            this.btn_salvar1.Name = "btn_salvar1";
            this.btn_salvar1.Size = new System.Drawing.Size(166, 63);
            this.btn_salvar1.TabIndex = 40;
            this.btn_salvar1.Text = "SALVAR";
            this.btn_salvar1.UseVisualStyleBackColor = false;
            this.btn_salvar1.Click += new System.EventHandler(this.btn_salvar1_Click);
            // 
            // lbl_foto1
            // 
            this.lbl_foto1.AutoSize = true;
            this.lbl_foto1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto1.Location = new System.Drawing.Point(62, 16);
            this.lbl_foto1.Name = "lbl_foto1";
            this.lbl_foto1.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto1.TabIndex = 20;
            this.lbl_foto1.Text = "Foto 1";
            // 
            // txtB_foto10
            // 
            this.txtB_foto10.Location = new System.Drawing.Point(259, 357);
            this.txtB_foto10.Name = "txtB_foto10";
            this.txtB_foto10.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto10.TabIndex = 39;
            // 
            // lbl_foto3
            // 
            this.lbl_foto3.AutoSize = true;
            this.lbl_foto3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto3.Location = new System.Drawing.Point(62, 95);
            this.lbl_foto3.Name = "lbl_foto3";
            this.lbl_foto3.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto3.TabIndex = 21;
            this.lbl_foto3.Text = "Foto 3";
            // 
            // txtB_foto9
            // 
            this.txtB_foto9.Location = new System.Drawing.Point(14, 357);
            this.txtB_foto9.Name = "txtB_foto9";
            this.txtB_foto9.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto9.TabIndex = 38;
            // 
            // lbl_foto5
            // 
            this.lbl_foto5.AutoSize = true;
            this.lbl_foto5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto5.Location = new System.Drawing.Point(62, 172);
            this.lbl_foto5.Name = "lbl_foto5";
            this.lbl_foto5.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto5.TabIndex = 22;
            this.lbl_foto5.Text = "Foto 5";
            // 
            // txtB_foto8
            // 
            this.txtB_foto8.Location = new System.Drawing.Point(259, 278);
            this.txtB_foto8.Name = "txtB_foto8";
            this.txtB_foto8.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto8.TabIndex = 37;
            // 
            // lbl_foto7
            // 
            this.lbl_foto7.AutoSize = true;
            this.lbl_foto7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto7.Location = new System.Drawing.Point(62, 252);
            this.lbl_foto7.Name = "lbl_foto7";
            this.lbl_foto7.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto7.TabIndex = 23;
            this.lbl_foto7.Text = "Foto 7";
            // 
            // txtB_foto7
            // 
            this.txtB_foto7.Location = new System.Drawing.Point(14, 278);
            this.txtB_foto7.Name = "txtB_foto7";
            this.txtB_foto7.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto7.TabIndex = 36;
            // 
            // lbl_foto9
            // 
            this.lbl_foto9.AutoSize = true;
            this.lbl_foto9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto9.Location = new System.Drawing.Point(62, 331);
            this.lbl_foto9.Name = "lbl_foto9";
            this.lbl_foto9.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto9.TabIndex = 24;
            this.lbl_foto9.Text = "Foto 9";
            // 
            // txtB_foto6
            // 
            this.txtB_foto6.Location = new System.Drawing.Point(259, 204);
            this.txtB_foto6.Name = "txtB_foto6";
            this.txtB_foto6.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto6.TabIndex = 35;
            // 
            // lbl_foto2
            // 
            this.lbl_foto2.AutoSize = true;
            this.lbl_foto2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto2.Location = new System.Drawing.Point(310, 16);
            this.lbl_foto2.Name = "lbl_foto2";
            this.lbl_foto2.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto2.TabIndex = 25;
            this.lbl_foto2.Text = "Foto 2";
            // 
            // txtB_foto5
            // 
            this.txtB_foto5.Location = new System.Drawing.Point(14, 198);
            this.txtB_foto5.Name = "txtB_foto5";
            this.txtB_foto5.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto5.TabIndex = 34;
            // 
            // lbl_foto4
            // 
            this.lbl_foto4.AutoSize = true;
            this.lbl_foto4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto4.Location = new System.Drawing.Point(310, 95);
            this.lbl_foto4.Name = "lbl_foto4";
            this.lbl_foto4.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto4.TabIndex = 26;
            this.lbl_foto4.Text = "Foto 4";
            // 
            // txtB_foto4
            // 
            this.txtB_foto4.Location = new System.Drawing.Point(259, 121);
            this.txtB_foto4.Name = "txtB_foto4";
            this.txtB_foto4.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto4.TabIndex = 33;
            // 
            // lbl_foto6
            // 
            this.lbl_foto6.AutoSize = true;
            this.lbl_foto6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto6.Location = new System.Drawing.Point(310, 178);
            this.lbl_foto6.Name = "lbl_foto6";
            this.lbl_foto6.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto6.TabIndex = 27;
            this.lbl_foto6.Text = "Foto 6";
            // 
            // txtB_foto3
            // 
            this.txtB_foto3.Location = new System.Drawing.Point(14, 121);
            this.txtB_foto3.Name = "txtB_foto3";
            this.txtB_foto3.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto3.TabIndex = 32;
            // 
            // lbl_foto8
            // 
            this.lbl_foto8.AutoSize = true;
            this.lbl_foto8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto8.Location = new System.Drawing.Point(310, 252);
            this.lbl_foto8.Name = "lbl_foto8";
            this.lbl_foto8.Size = new System.Drawing.Size(58, 23);
            this.lbl_foto8.TabIndex = 28;
            this.lbl_foto8.Text = "Foto 8";
            // 
            // txtB_foto2
            // 
            this.txtB_foto2.Location = new System.Drawing.Point(259, 42);
            this.txtB_foto2.Name = "txtB_foto2";
            this.txtB_foto2.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto2.TabIndex = 31;
            // 
            // lbl_foto10
            // 
            this.lbl_foto10.AutoSize = true;
            this.lbl_foto10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto10.Location = new System.Drawing.Point(310, 331);
            this.lbl_foto10.Name = "lbl_foto10";
            this.lbl_foto10.Size = new System.Drawing.Size(67, 23);
            this.lbl_foto10.TabIndex = 29;
            this.lbl_foto10.Text = "Foto 10";
            // 
            // txtB_foto1
            // 
            this.txtB_foto1.Location = new System.Drawing.Point(14, 42);
            this.txtB_foto1.Name = "txtB_foto1";
            this.txtB_foto1.Size = new System.Drawing.Size(167, 20);
            this.txtB_foto1.TabIndex = 30;
            // 
            // tbP_entrega
            // 
            this.tbP_entrega.Controls.Add(this.grpB_entrega);
            this.tbP_entrega.Location = new System.Drawing.Point(4, 22);
            this.tbP_entrega.Name = "tbP_entrega";
            this.tbP_entrega.Size = new System.Drawing.Size(482, 760);
            this.tbP_entrega.TabIndex = 2;
            this.tbP_entrega.Text = "Entrega";
            this.tbP_entrega.UseVisualStyleBackColor = true;
            // 
            // grpB_entrega
            // 
            this.grpB_entrega.Controls.Add(this.btn_salvar2);
            this.grpB_entrega.Controls.Add(this.btn_Cancelar);
            this.grpB_entrega.Controls.Add(this.btn_addNovaEntrega);
            this.grpB_entrega.Controls.Add(this.txtB_entrega);
            this.grpB_entrega.Enabled = false;
            this.grpB_entrega.Location = new System.Drawing.Point(-4, -10);
            this.grpB_entrega.Name = "grpB_entrega";
            this.grpB_entrega.Size = new System.Drawing.Size(495, 777);
            this.grpB_entrega.TabIndex = 43;
            this.grpB_entrega.TabStop = false;
            // 
            // btn_salvar2
            // 
            this.btn_salvar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_salvar2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_salvar2.ForeColor = System.Drawing.Color.White;
            this.btn_salvar2.Location = new System.Drawing.Point(160, 360);
            this.btn_salvar2.Name = "btn_salvar2";
            this.btn_salvar2.Size = new System.Drawing.Size(148, 45);
            this.btn_salvar2.TabIndex = 41;
            this.btn_salvar2.Text = "SALVAR";
            this.btn_salvar2.UseVisualStyleBackColor = false;
            this.btn_salvar2.Click += new System.EventHandler(this.btn_salvar2_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(238, 64);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(88, 33);
            this.btn_Cancelar.TabIndex = 42;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_addNovaEntrega
            // 
            this.btn_addNovaEntrega.BackColor = System.Drawing.Color.LightBlue;
            this.btn_addNovaEntrega.Location = new System.Drawing.Point(136, 64);
            this.btn_addNovaEntrega.Name = "btn_addNovaEntrega";
            this.btn_addNovaEntrega.Size = new System.Drawing.Size(83, 33);
            this.btn_addNovaEntrega.TabIndex = 2;
            this.btn_addNovaEntrega.Text = "Novo";
            this.btn_addNovaEntrega.UseVisualStyleBackColor = false;
            this.btn_addNovaEntrega.Click += new System.EventHandler(this.btn_addNovaEntrega_Click);
            // 
            // txtB_entrega
            // 
            this.txtB_entrega.Enabled = false;
            this.txtB_entrega.Location = new System.Drawing.Point(136, 120);
            this.txtB_entrega.Multiline = true;
            this.txtB_entrega.Name = "txtB_entrega";
            this.txtB_entrega.Size = new System.Drawing.Size(190, 46);
            this.txtB_entrega.TabIndex = 1;
            // 
            // pnl_dados
            // 
            this.pnl_dados.AutoScroll = true;
            this.pnl_dados.BackColor = System.Drawing.Color.White;
            this.pnl_dados.Controls.Add(this.tbc_dados);
            this.pnl_dados.Location = new System.Drawing.Point(0, 87);
            this.pnl_dados.Name = "pnl_dados";
            this.pnl_dados.Size = new System.Drawing.Size(490, 789);
            this.pnl_dados.TabIndex = 23;
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataToolStripMenuItem.Text = "Data Planilha";
            this.dataToolStripMenuItem.Visible = false;
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // dataNomeFotoToolStripMenuItem
            // 
            this.dataNomeFotoToolStripMenuItem.Name = "dataNomeFotoToolStripMenuItem";
            this.dataNomeFotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataNomeFotoToolStripMenuItem.Text = "Data Nome Foto";
            this.dataNomeFotoToolStripMenuItem.Visible = false;
            this.dataNomeFotoToolStripMenuItem.Click += new System.EventHandler(this.dataNomeFotoToolStripMenuItem_Click);
            // 
            // kMToolStripMenuItem
            // 
            this.kMToolStripMenuItem.Name = "kMToolStripMenuItem";
            this.kMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kMToolStripMenuItem.Text = "KM";
            this.kMToolStripMenuItem.Click += new System.EventHandler(this.kMToolStripMenuItem_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 41;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // coordX
            // 
            this.coordX.HeaderText = "Latitude";
            this.coordX.Name = "coordX";
            this.coordX.Width = 70;
            // 
            // coordY
            // 
            this.coordY.HeaderText = "Longitude";
            this.coordY.Name = "coordY";
            this.coordY.Width = 79;
            // 
            // rodovia
            // 
            this.rodovia.HeaderText = "Rodovia";
            this.rodovia.Name = "rodovia";
            this.rodovia.Width = 72;
            // 
            // km
            // 
            this.km.HeaderText = "KM";
            this.km.Name = "km";
            this.km.Width = 48;
            // 
            // metro
            // 
            this.metro.HeaderText = "Metro";
            this.metro.Name = "metro";
            this.metro.Width = 59;
            // 
            // trecho
            // 
            this.trecho.HeaderText = "Trecho";
            this.trecho.Name = "trecho";
            this.trecho.Width = 66;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.Width = 53;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.Width = 54;
            // 
            // camada1
            // 
            this.camada1.HeaderText = "Camada 01";
            this.camada1.Name = "camada1";
            this.camada1.Width = 86;
            // 
            // camada2
            // 
            this.camada2.HeaderText = "Camada 02";
            this.camada2.Name = "camada2";
            this.camada2.Width = 86;
            // 
            // camada3
            // 
            this.camada3.HeaderText = "Camada 03";
            this.camada3.Name = "camada3";
            this.camada3.Width = 86;
            // 
            // camada4
            // 
            this.camada4.HeaderText = "Camada 04";
            this.camada4.Name = "camada4";
            this.camada4.Width = 86;
            // 
            // espessura1
            // 
            this.espessura1.HeaderText = "Espessura 1";
            this.espessura1.Name = "espessura1";
            this.espessura1.Width = 90;
            // 
            // espessura2
            // 
            this.espessura2.HeaderText = "Espessura 2";
            this.espessura2.Name = "espessura2";
            this.espessura2.Width = 90;
            // 
            // espessura3
            // 
            this.espessura3.HeaderText = "Espessura 3";
            this.espessura3.Name = "espessura3";
            this.espessura3.Width = 90;
            // 
            // espessura4
            // 
            this.espessura4.HeaderText = "Espessura 4";
            this.espessura4.Name = "espessura4";
            this.espessura4.Width = 90;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 62;
            // 
            // observacao
            // 
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            this.observacao.Width = 90;
            // 
            // foto
            // 
            this.foto.HeaderText = "NomeFoto";
            this.foto.Name = "foto";
            this.foto.Width = 81;
            // 
            // entrega
            // 
            this.entrega.HeaderText = "Entrega";
            this.entrega.Name = "entrega";
            this.entrega.Width = 69;
            // 
            // regional
            // 
            this.regional.HeaderText = "Regional";
            this.regional.Name = "regional";
            this.regional.Width = 74;
            // 
            // dataCadastro
            // 
            this.dataCadastro.HeaderText = "Data Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            // 
            // relátorioPDFToolStripMenuItem
            // 
            this.relátorioPDFToolStripMenuItem.Name = "relátorioPDFToolStripMenuItem";
            this.relátorioPDFToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.relátorioPDFToolStripMenuItem.Text = "Relátorio PDF";
            this.relátorioPDFToolStripMenuItem.Click += new System.EventHandler(this.relátorioPDFToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1334, 891);
            this.Controls.Add(this.pnl_dados);
            this.Controls.Add(this.grpB_foto);
            this.Controls.Add(this.btn_importarBD);
            this.Controls.Add(this.grpB_mapa);
            this.Controls.Add(this.grpB_planilha);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Esteio Sondagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sondagem)).EndInit();
            this.grpB_planilha.ResumeLayout(false);
            this.grpB_planilha.PerformLayout();
            this.grpB_mapa.ResumeLayout(false);
            this.grpB_mapa.PerformLayout();
            this.grpB_foto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc_dados.ResumeLayout(false);
            this.tbP_dados.ResumeLayout(false);
            this.tbP_dados.PerformLayout();
            this.grpB_dados.ResumeLayout(false);
            this.grpB_dados.PerformLayout();
            this.tbp_foto.ResumeLayout(false);
            this.grpB_fotosEditarNome.ResumeLayout(false);
            this.grpB_fotosEditarNome.PerformLayout();
            this.tbP_entrega.ResumeLayout(false);
            this.grpB_entrega.ResumeLayout(false);
            this.grpB_entrega.PerformLayout();
            this.pnl_dados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_importarBD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpB_mapa;
        private System.Windows.Forms.GroupBox grpB_foto;
        private System.Windows.Forms.ListView lstView_listaFoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_importarPanilha;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_organizar;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_foto;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_planilha;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoRedeToolStripMenuItem;
        public DataGridView dgv_sondagem;
        public GroupBox grpB_planilha;
        private Label lbl_legendaFiltro;
        private Button btn_search;
        private ToolStripSeparator toolStripSeparator1;
        private TabControl tbc_dados;
        private TabPage tbP_dados;
        private GroupBox grpB_dados;
        private TextBox txtB_obs;
        private TextBox txtB_status;
        private TextBox txtB_espessura4;
        private TextBox txtB_espessura3;
        private TextBox txtB_espessura2;
        private TextBox txtB_espessura1;
        private TextBox txtB_camada4;
        private TextBox txtB_camada3;
        private TextBox txtB_camada2;
        private TextBox txtB_camada1;
        private TextBox txtB_area;
        private TextBox txtB_lote;
        private TextBox txtB_trecho;
        private TextBox txtB_metro;
        private TextBox txtB_km;
        private TextBox txtB_rodovia;
        private TextBox txtB_longitude;
        private Label lbl_obs;
        private Label lbl_status;
        private Label lbl_espessura4;
        private Label lbl_espessura3;
        private Label lbl_espessura2;
        private Label lbl_espessura1;
        private Label lbl_trecho;
        private Label lbl_camada4;
        private Label lbl_metro;
        private Label lbl_camada3;
        private Label lbl_km;
        private Label lbl_camada1;
        private Label lbl_area;
        private Label lbl_camada2;
        private Label lbl_rodovia;
        private Label lbl_longitude;
        private Label lbl_lote;
        private Button btn_salvar;
        private TextBox txtB_latitude;
        private Label lbl_latitude;
        private TextBox txtB_nameProj;
        private Label lbl_nomeProjeto;
        private TabPage tbp_foto;
        private GroupBox grpB_fotosEditarNome;
        private Button btn_salvar1;
        private Label lbl_foto1;
        public TextBox txtB_foto10;
        private Label lbl_foto3;
        public TextBox txtB_foto9;
        private Label lbl_foto5;
        public TextBox txtB_foto8;
        private Label lbl_foto7;
        public TextBox txtB_foto7;
        private Label lbl_foto9;
        public TextBox txtB_foto6;
        private Label lbl_foto2;
        public TextBox txtB_foto5;
        private Label lbl_foto4;
        public TextBox txtB_foto4;
        private Label lbl_foto6;
        public TextBox txtB_foto3;
        private Label lbl_foto8;
        public TextBox txtB_foto2;
        private Label lbl_foto10;
        public TextBox txtB_foto1;
        private Panel pnl_dados;
        private Panel pnl_button;
        private Label lbl_linhaLote;
        private Label lbl_quantidadeLinhas;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private TabPage tbP_entrega;
        private Button btn_addNovaEntrega;
        private TextBox txtB_entrega;
        private ComboBox cmbB_entrega;
        private Button btn_salvar2;
        private ComboBox cmbB_entregaFiltro;
        private Label lbl_entregaFiltro;
        private Button btn_Cancelar;
        private GroupBox grpB_entrega;
        public ComboBox cmbB_Lotes;
        private Label lbl_entrega;
        private ToolStripMenuItem toolstrip_relatorio;
        private ToolStripMenuItem toolstrip_relatorioParcial;
        private ToolStripMenuItem toolstrip_relatorioCompleto;
        private ToolStripMenuItem reToolStripMenuItem;
        private Button btn_multiSelect;
        private ToolStripMenuItem relátorioWORDToolStripMenuItem;
        private Label lbl_regional;
        private ComboBox cmbB_regional;
        private ToolStripMenuItem regionalToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem dataNomeFotoToolStripMenuItem;
        private ToolStripMenuItem kMToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn coordX;
        private DataGridViewTextBoxColumn coordY;
        private DataGridViewTextBoxColumn rodovia;
        private DataGridViewTextBoxColumn km;
        private DataGridViewTextBoxColumn metro;
        private DataGridViewTextBoxColumn trecho;
        private DataGridViewTextBoxColumn lote;
        private DataGridViewTextBoxColumn area;
        private DataGridViewTextBoxColumn camada1;
        private DataGridViewTextBoxColumn camada2;
        private DataGridViewTextBoxColumn camada3;
        private DataGridViewTextBoxColumn camada4;
        private DataGridViewTextBoxColumn espessura1;
        private DataGridViewTextBoxColumn espessura2;
        private DataGridViewTextBoxColumn espessura3;
        private DataGridViewTextBoxColumn espessura4;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn observacao;
        private DataGridViewTextBoxColumn foto;
        private DataGridViewTextBoxColumn entrega;
        private DataGridViewTextBoxColumn regional;
        private DataGridViewTextBoxColumn dataCadastro;
        private ToolStripMenuItem relátorioPDFToolStripMenuItem;
    }
}