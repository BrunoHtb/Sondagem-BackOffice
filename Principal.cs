using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Threading;
using System.Windows.Input;
using ProgFormularioEngenharia2.sondagemClasses;
using ProgFormularioEngenharia2.sondagem;

namespace ProgFormularioEngenharia2
{
    public partial class Frm_Principal : Form
    {
        int idEditar;
        string camada;
        string espessura;
        string[] campo;
        string grid;
        string linha;
        public string nomeFoto = "";
        string localhost;
        string caminhoFotoSalva;
        List<string> fotos;
        Frm_Fotos frmFotos;
        string filtro = "*";
        string filtroEntrega = "*";
        string tipoEntrega = "normal";
        Frm_loading load = new Frm_loading();
        string caminhoWordSalva;
        Login frmLogin;
        public object DBConnection { get; private set; }

        public Frm_Principal(Login FrmLogin)
        {
            this.frmLogin = FrmLogin;
            this.frmFotos = new Frm_Fotos();
            this.fotos = new List<string>();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            cmbB_Lotes.Text = "*";
            cmbB_entregaFiltro.Text = "*";
            Load_Config();
        }

        private void Load_Config()
        {
            try
            {
                if (File.Exists(".\\Config.txt"))
                {
                    using (StreamReader sr = File.OpenText(".\\Config.txt"))
                    {
                        string s = ""; int _index = 0;
                        while ((s = sr.ReadLine()) != null)
                        {
                            switch (_index)
                            {
                                case 0:
                                    localhost = s;
                                    break;
                                case 1:
                                    caminhoFotoSalva = s;
                                    break;
                                case 2:
                                    caminhoWordSalva = s;
                                    break;
                            }
                            _index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi encontrado o diretorio de Imagens \n\r\n" + ex);
            }
        }

        private void btnEditarPlanilha_Click(object sender, EventArgs e)
        {
            try
            {
                grpB_dados.Enabled = true;
                grpB_fotosEditarNome.Enabled = true;
                grpB_entrega.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi encontrado o diretorio de Imagens \n\r\n" + ex);
            }
        }

        //PEGA OS DADOS DO BD
        private void btnImportatBD_Click(object sender, EventArgs e)
        {
            try
            {
                toolstrip_relatorio.Enabled = true;
                atualizaGrid();
                lbl_linhaLote.Text = (dgv_sondagem.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Puxa a taabela do BD e preenche os dados no TextBox ao clicar nas celulas
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //RESETA os valores
                grpB_dados.Enabled = false;
                grpB_fotosEditarNome.Enabled = false;
                grpB_entrega.Enabled = false;

                lstView_listaFoto.Clear();
                fotos.Clear();
                //pct_box.Image = null;
                frmFotos.pct_boxMaior_Exibir(null);

                if (dgv_sondagem.RowCount != 1)
                {
                    btn_Deletar.Enabled = true;
                    btn_Editar.Enabled = true;

                    //Pega o ID da linha selecionado na planilha
                    idEditar = Convert.ToInt32(dgv_sondagem.SelectedRows[0].Cells[0].Value.ToString());

                    //Preenche os campos 
                    txtB_nameProj.Text = dgv_sondagem.SelectedRows[0].Cells[1].Value.ToString();
                    txtB_latitude.Text = dgv_sondagem.SelectedRows[0].Cells[2].Value.ToString();
                    txtB_longitude.Text = dgv_sondagem.SelectedRows[0].Cells[3].Value.ToString();
                    txtB_rodovia.Text = dgv_sondagem.SelectedRows[0].Cells[4].Value.ToString();
                    txtB_km.Text = dgv_sondagem.SelectedRows[0].Cells[5].Value.ToString();
                    txtB_metro.Text = dgv_sondagem.SelectedRows[0].Cells[6].Value.ToString();
                    txtB_trecho.Text = dgv_sondagem.SelectedRows[0].Cells[7].Value.ToString();
                    txtB_lote.Text = dgv_sondagem.SelectedRows[0].Cells[8].Value.ToString();
                    txtB_area.Text = dgv_sondagem.SelectedRows[0].Cells[9].Value.ToString();
                    txtB_camada1.Text = dgv_sondagem.SelectedRows[0].Cells[10].Value.ToString();
                    txtB_camada2.Text = dgv_sondagem.SelectedRows[0].Cells[11].Value.ToString();
                    txtB_camada3.Text = dgv_sondagem.SelectedRows[0].Cells[12].Value.ToString();
                    txtB_camada4.Text = dgv_sondagem.SelectedRows[0].Cells[13].Value.ToString();
                    txtB_espessura1.Text = dgv_sondagem.SelectedRows[0].Cells[14].Value.ToString();
                    txtB_espessura2.Text = dgv_sondagem.SelectedRows[0].Cells[15].Value.ToString();
                    txtB_espessura3.Text = dgv_sondagem.SelectedRows[0].Cells[16].Value.ToString();
                    txtB_espessura4.Text = dgv_sondagem.SelectedRows[0].Cells[17].Value.ToString();
                    txtB_status.Text = dgv_sondagem.SelectedRows[0].Cells[18].Value.ToString();
                    txtB_obs.Text = dgv_sondagem.SelectedRows[0].Cells[19].Value.ToString();

                    nomeFoto = dgv_sondagem.SelectedRows[0].Cells[20].Value.ToString();
                    txtB_entrega.Text = dgv_sondagem.SelectedRows[0].Cells[21].Value.ToString();
                    cmbB_entrega.SelectedItem = dgv_sondagem.SelectedRows[0].Cells[21].Value.ToString();
                    cmbB_regional.SelectedItem = dgv_sondagem.SelectedRows[0].Cells[22].Value.ToString();

                    if (nomeFoto != "; ; ; ; ; ; ; ; ; ")
                    {
                        string[] listaFoto = nomeFoto.Split(';');

                        txtB_foto1.Text = listaFoto[0];
                        txtB_foto2.Text = listaFoto[1];
                        txtB_foto3.Text = listaFoto[2];
                        txtB_foto4.Text = listaFoto[3];
                        txtB_foto5.Text = listaFoto[4];
                        txtB_foto6.Text = listaFoto[5];
                        txtB_foto7.Text = listaFoto[6];
                        txtB_foto8.Text = listaFoto[7];
                        txtB_foto9.Text = listaFoto[8];
                        txtB_foto10.Text = listaFoto[9];
                    }
                    gMap_Update();
                    loadPicture();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //SALVA AS ALTERAÇÕES NO BD (EDITAR)
        public void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DAL DbConnection = new DAL(localhost);
                this.camada = txtB_camada1.Text.ToString() + ";" + txtB_camada2.Text.ToString() + ";" + txtB_camada3.Text.ToString() + ";" + txtB_camada4.Text.ToString();
                this.espessura = txtB_espessura1.Text.ToString() + ";" + txtB_espessura2.Text.ToString() + ";" + txtB_espessura3.Text.ToString() + ";" + txtB_espessura4.Text.ToString();
                string entrega;

                //Concatena os nomes das fotos (nomeFoto)
                concatenarNomeFoto();

                if (txtB_entrega.Enabled == true)
                {
                    entrega = txtB_entrega.Text.ToString();
                    txtB_entrega.Enabled = false;
                    cmbB_entrega.Enabled = true;
                }
                else
                {
                    entrega = cmbB_entrega.SelectedItem.ToString();
                }

                string cmdAtualiza = String.Format("UPDATE sondagemdado SET nome='" + txtB_nameProj.Text.ToString() + "', latitude='" + txtB_latitude.Text.ToString() + "'" +
                    ", longitude='" + txtB_longitude.Text.ToString() + "', rodovia='" + txtB_rodovia.Text.ToString() + "', km='" + txtB_km.Text.ToString() + "', metro='" + txtB_metro.Text.ToString() + "'" +
                    ", trecho='" + txtB_trecho.Text.ToString() + "', lote='" + txtB_lote.Text.ToString() + "', foto= '" + nomeFoto + "', area='" + txtB_area.Text.ToString() + "', camada='" + camada + "'" +
                    ", espessura='" + espessura + "', status='" + txtB_status.Text.ToString() + "', observacao='" + txtB_obs.Text.ToString()
                    + "', entrega='" + entrega + "', regional='" + cmbB_regional.SelectedItem.ToString() + "' WHERE id=" + idEditar);

                DbConnection.editarDatabase(cmdAtualiza, DbConnection);

                MessageBox.Show("Dados salvo com sucesso", "Banco de Dados Atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //cmbB_Lotes.Items.Clear();
                //cmbB_entrega.Items.Clear();
                //cmbB_entregaFiltro.Items.Clear();

                atualizaGrid();

                ((IDisposable)DbConnection).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //DELETA a linha selecionada na tabela
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DAL DbConnection = new DAL(localhost);
                grpB_dados.Enabled = true;

                if (MessageBox.Show("Tem certeza de que deseja deletar?", "Excluir o dado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbConnection.deletarDatabase(idEditar, DbConnection);
                    atualizaGrid();
                }
                ((IDisposable)DbConnection).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Carrega o mapa e coloca o marcador a partir da latitude e longitude
        private void gMap_Update()
        {
            if (idEditar > 0)
            {
                try
                {
                    double lat = Convert.ToDouble(dgv_sondagem.SelectedRows[0].Cells[2].Value.ToString());
                    double lng = Convert.ToDouble(dgv_sondagem.SelectedRows[0].Cells[3].Value.ToString());

                    gMap.DragButton = MouseButtons.Left;
                    gMap.MapProvider = GMapProviders.GoogleMap;
                    gMap.Position = new PointLatLng(lat, lng);
                    gMap.ShowCenter = false;
                    gMap.MinZoom = 10;
                    gMap.MaxZoom = 30;
                    gMap.Zoom = 15;


                    /* Cria o marcador e fixa ele no mapa */
                    PointLatLng point = new PointLatLng(lat, lng);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                    GMapOverlay markers = new GMapOverlay("markers");

                    gMap.Overlays.Clear();
                    markers.Markers.Add(marker);
                    gMap.Overlays.Add(markers);

                    //APARECE ALGUMAS INFORMAÇÕES NO MARCADOR
                    marker.ToolTipText = string.Format("Nome: " + dgv_sondagem.SelectedRows[0].Cells[1].Value.ToString() + "\n" +
                                                       "Lote: " + dgv_sondagem.SelectedRows[0].Cells[8].Value.ToString() + "\n" +
                                                       "Área: " + dgv_sondagem.SelectedRows[0].Cells[9].Value.ToString() + "\n" +
                                                       "Trecho: " + dgv_sondagem.SelectedRows[0].Cells[7].Value.ToString() + "\n" +
                                                       "Status: " + dgv_sondagem.SelectedRows[0].Cells[18].Value.ToString() + "\n");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        public void atualizaGrid()
        {
            try
            {
                DAL DbConnection = new DAL(localhost);

                //LIMPAR A PLANILHA
                dgv_sondagem.Rows.Clear();
                grid = "";

                using (var conn = new NpgsqlConnection(DbConnection.GET()))
                {
                    Console.Out.WriteLine("Opening connection");
                    conn.Open();

                    var command = new NpgsqlCommand();
                    string comando = comandoBD();
                    command = new NpgsqlCommand(comando, conn);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        grid = string.Format(
                        reader.GetInt32(0).ToString() + ";" + reader.GetString(1) + ";" +
                        reader.GetString(2) + ";" + reader.GetString(3) + ";" +
                        reader.GetString(4) + ";" + reader.GetString(5) + ";" +
                        reader.GetString(6) + ";" + reader.GetString(7) + ";" +
                        reader.GetString(8) + ";" + reader.GetString(9) + ";" +
                        reader.GetString(10) + ";" + reader.GetString(11) + ";" +
                        reader.GetString(12) + ";" + reader.GetString(13) + ";" +
                        reader.GetString(14) + ";" + reader.GetString(15) + ";" +
                        reader.GetString(16) + ";" + reader.GetString(17) + ";" +
                        reader.GetString(18) + ";" + reader.GetString(19) + ";" +
                        reader.GetString(20));
                        campo = grid.Split(';');

                        nomeFoto = string.Format(reader.GetString(12));

                        dgv_sondagem.Rows.Add(
                            campo[0], //ID
                            campo[1], //Nome
                            campo[5], //Latitude
                            campo[6], //Longitude
                            campo[7], //Rodovia
                            campo[8], //KM
                            campo[9], //Metros
                            campo[10], //Trecho
                            campo[11], //Lote
                            campo[22], //Area
                            campo[23], //Camada 1
                            campo[24], //Camada 2
                            campo[25], //Camada 3
                            campo[26],  //Camada 4
                            campo[27],  //Espessura 1
                            campo[28],  //Espessura 2
                            campo[29],  //Espessura 3
                            campo[30],  //Espessura 4
                            campo[31],  //Status
                            campo[32],  //Observação
                            nomeFoto,
                            campo[33],  //Entrega
                            campo[34],   //regional
                            campo[35]   //Data cadastro
                                        //grid[12] até grid[21] são nome das fotos 
                            );

                        if (cmbB_Lotes.FindStringExact(campo[11]) == -1)
                        {
                            cmbB_Lotes.Items.Add(campo[11]);
                        }
                        if (cmbB_entrega.FindStringExact(campo[33]) == -1)
                        {
                            cmbB_entrega.Items.Add(campo[33]);
                            cmbB_entregaFiltro.Items.Add(campo[33]);
                        }
                        Array.Clear(campo, 0, campo.Length);
                    }
                    reader.Close();
                    conn.Close();
                }
                ((IDisposable)DbConnection).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private string comandoBD()
        {
            string comando;

            if (filtro == "*" && filtroEntrega == "*")
            {
                comando = "SELECT * FROM sondagemdado ORDER BY nome";
            }
            else if (filtro == "*" && filtroEntrega != "*")
            {
                comando = "SELECT * FROM sondagemdado WHERE entrega = '" + filtroEntrega + "' ORDER BY nome";
            }
            else if (filtro != "*" && filtroEntrega == "*")
            {
                comando = "SELECT * FROM sondagemdado WHERE lote = '" + filtro + "' ORDER BY nome";
            }
            else
            {
                comando = "SELECT * FROM sondagemdado WHERE lote = '" + filtro + "' AND entrega = '" + filtroEntrega + "' ORDER BY nome ";
            }

            return comando;
        }

        private void lstView_listaFoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selected = lstView_listaFoto.SelectedItems[0].SubItems[0].Text;
            Utilidade aux = new Utilidade();
            int i = aux.valorClicadoFoto(selected);
            try
            {
                if (i != -1)
                {
                    //Caso o usuário feche a janela
                    if (frmFotos.closed == true)
                    {
                        frmFotos.Dispose();
                        frmFotos = new Frm_Fotos();
                    }
                    frmFotos.Show();
                    Bitmap bm = new Bitmap(@"" + fotos[i]);
                    frmFotos.pct_boxMaior_Exibir(bm);
                }
                else
                {
                    MessageBox.Show("Erro ao abrir a Imagem");
                }
            }
            catch (Exception ex)
            {
                frmFotos.pct_boxMaior_Exibir(null);
            }
        }


        private void importarPanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DAL DbConnection = new DAL(localhost);
                ofd.Multiselect = true;
                ofd.Filter = " CSV |*.csv";
                Utilidade planilhaMain = new Utilidade();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in ofd.FileNames)
                    {
                        StreamReader csv = new StreamReader(file);
                        while ((linha = csv.ReadLine()) != null)
                        {
                            campo = linha.Split(';');
                            //*-------------------  SALVAR DADOS NO BANCO  ------------------------------*
                            DbConnection.saveDatabase(campo);
                        }

                        if (!Directory.Exists(Path.GetDirectoryName(Path.GetDirectoryName(file) + "\\Concluido\\")))
                        {
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(file) + "\\Concluido\\");
                        }
                        csv.Close();
                        System.IO.File.Copy(file, (Path.GetDirectoryName(file) + "\\Concluido\\" + Path.GetFileName(file)));
                        System.IO.File.Delete(file);
                    }
                }
                atualizaGrid();
                ((IDisposable)DbConnection).Dispose();
                ((IDisposable)ofd).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void toolstrip_fotoOrganizar_Click(object sender, EventArgs e)
        {
            try
            {
                ImportarFotos ft = new ImportarFotos(caminhoFotoSalva);
                ft.moverFoto();
                ((IDisposable)ft).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void toolstrip_planilhaOrganizar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidade planilha = new Utilidade();
                planilha.moverPlanilha();
                ((IDisposable)planilha).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void configuraçãoRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Configuração frm_config = new Frm_Configuração(localhost, caminhoFotoSalva, caminhoWordSalva);
            frm_config.ShowDialog();
            Load_Config();
            ((IDisposable)frm_config).Dispose();
        }

        private void loadPicture()
        {
            ImportarFotos ft = new ImportarFotos(caminhoFotoSalva);
            List<string> imgs = new List<string>();
            ImageList listV_imgs = new ImageList();
            listV_imgs.ImageSize = new Size(100, 80);

            imgs.Clear();
            imgs = ft.viewFoto(nomeFoto);
            int i = 0;

            foreach (string arq in imgs)
            {
                if (arq == null && i < 10)
                {
                    listV_imgs.Images.Add(Image.FromFile(".\\Images\\nonImage.png"));
                    fotos.Add(".\\Images\\nonImage.png");
                }
                else if (arq == null && i >= 10)
                {
                    break;
                }
                else
                {
                    listV_imgs.Images.Add(Image.FromFile(arq));
                    fotos.Add(arq);
                }
                i++;
            }

            lstView_listaFoto.View = View.Details;
            lstView_listaFoto.Columns.Add("", 250);
            lstView_listaFoto.SmallImageList = listV_imgs;

            lstView_listaFoto.Items.Add("PANORÂMICA", 0);
            lstView_listaFoto.Items.Add("CAMADAS", 1);
            lstView_listaFoto.Items.Add("FINAL FURO", 2);
            lstView_listaFoto.Items.Add("AMOSTRAS", 3);
            lstView_listaFoto.Items.Add("FURO FECHADO", 4);
            lstView_listaFoto.Items.Add("BOLETIM", 5);
            lstView_listaFoto.Items.Add("SITU 01", 6);
            lstView_listaFoto.Items.Add("SITU 02", 7);
            lstView_listaFoto.Items.Add("SITU 03", 8);
            lstView_listaFoto.Items.Add("SITU 04", 9);

            ((IDisposable)ft).Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                filtro = cmbB_Lotes.SelectedItem.ToString();
                filtroEntrega = cmbB_entregaFiltro.SelectedItem.ToString();
                atualizaGrid();
                lbl_linhaLote.Text = (dgv_sondagem.Rows.Count - 1).ToString();
            }
            catch (Exception ex) { }
        }

        public void concatenarNomeFoto()
        {
            //Nome Foto 1
            if (String.IsNullOrEmpty(txtB_foto1.Text))
            {
                nomeFoto = ";";
            }
            else
            {
                nomeFoto = txtB_foto1.Text.ToString() + ";";
            }
            //Nome Foto 2
            if (!String.IsNullOrEmpty(txtB_foto2.Text))
            {
                nomeFoto += txtB_foto2.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 3
            if (!String.IsNullOrEmpty(txtB_foto3.Text))
            {
                nomeFoto += txtB_foto3.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 4
            if (!String.IsNullOrEmpty(txtB_foto4.Text))
            {
                nomeFoto += txtB_foto4.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 5
            if (!String.IsNullOrEmpty(txtB_foto5.Text))
            {
                nomeFoto += txtB_foto5.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 6
            if (!String.IsNullOrEmpty(txtB_foto6.Text))
            {
                nomeFoto += txtB_foto6.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 7
            if (!String.IsNullOrEmpty(txtB_foto7.Text))
            {
                nomeFoto += txtB_foto7.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 8
            if (!String.IsNullOrEmpty(txtB_foto8.Text))
            {
                nomeFoto += txtB_foto8.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 9
            if (!String.IsNullOrEmpty(txtB_foto9.Text))
            {
                nomeFoto += txtB_foto9.Text.ToString() + ";";
            }
            else
            {
                nomeFoto += ";";
            }
            //Nome Foto 10
            if (!String.IsNullOrEmpty(txtB_foto10.Text))
            {
                nomeFoto += txtB_foto10.Text.ToString();
            }
        }

        private void btn_salvar1_Click(object sender, EventArgs e)
        {
            btn_salvar_Click(sender, e);
        }

        private void dgv_sondagem_KeyPress(object sender, KeyPressEventArgs e) { }

        private void btn_addNovaEntrega_Click(object sender, EventArgs e)
        {
            txtB_entrega.Enabled = true;
            cmbB_entrega.Enabled = false;
            btn_Cancelar.Enabled = true;
        }

        private void btn_salvar2_Click(object sender, EventArgs e)
        {
            btn_salvar_Click(sender, e);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txtB_entrega.Enabled = false;
            cmbB_entrega.Enabled = true;
            btn_Cancelar.Enabled = false;
        }

        private void toolstrip_relatorioParcial_Click(object sender, EventArgs e)
        {

            try
            {
                Relatorio relatorio = new Relatorio(cmbB_Lotes.SelectedItem.ToString(), cmbB_entregaFiltro.SelectedItem.ToString(), localhost, caminhoFotoSalva);
                relatorio.GerarRelatorioParcial();
                relatorio = null;
            }
            catch (Exception ex) { }

        }

        private void toolstrip_relatorioCompleto_Click(object sender, EventArgs e)
        {

            try
            {
                Relatorio relatorio = new Relatorio(cmbB_Lotes.SelectedItem.ToString(), cmbB_entregaFiltro.SelectedItem.ToString(), localhost, caminhoFotoSalva);
                relatorio.GerarRelatorioCompleto();
                relatorio = null;
            }
            catch (Exception ex) { }

        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Relatorio relatorio = new Relatorio(cmbB_Lotes.SelectedItem.ToString(), cmbB_entregaFiltro.SelectedItem.ToString(), localhost, caminhoFotoSalva);
            relatorio.GerarRelatorioParcialSemFotos();
            relatorio = null;

        }

        private void btn_multiSelect_Click_1(object sender, EventArgs e)
        {
            string nome, entrega;
            int id;
            string[] filtroAux = new string[cmbB_entregaFiltro.Items.Count];

            for (int i = 0; i < cmbB_entregaFiltro.Items.Count; i++)
            {
                filtroAux[i] = cmbB_entregaFiltro.Items[i].ToString();
            }

            Frm_MultiSelect frmMultiSelect = new Frm_MultiSelect(filtroAux, this);

            for (int i = 0; i < dgv_sondagem.Rows.Count - 1; i++)
            {
                id = Int32.Parse(dgv_sondagem.Rows[i].Cells[0].Value.ToString());
                nome = dgv_sondagem.Rows[i].Cells[1].Value.ToString();
                entrega = dgv_sondagem.Rows[i].Cells[21].Value.ToString();

                frmMultiSelect.fill_Grid(id, nome, entrega);
            }

            frmMultiSelect.Show();
        }

        public void multiSave()
        {
            this.tipoEntrega = "multi";
        }

        private void relátorioWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbdRelatorioWord = new FolderBrowserDialog();
                string pathRelatorio;

                if (fbdRelatorioWord.ShowDialog() == DialogResult.OK)
                {
                    pathRelatorio = fbdRelatorioWord.SelectedPath + "\\";
                    RelatorioWord relatorioWord = new RelatorioWord(pathRelatorio, caminhoFotoSalva);

                    /*Inicia o contador*/
                    if (load.firstTime == true)
                    {
                        load.maxCount_load(dgv_sondagem.Rows.Count - 1);
                        load.Show();
                    }

                    for (int i = 0; i < dgv_sondagem.Rows.Count - 1; i++)
                    {
                        load.loading();
                        relatorioWord.geraRelatorioWord(
                            caminhoWordSalva,
                            dgv_sondagem.Rows[i].Cells[8].Value.ToString(),     //Lote
                            dgv_sondagem.Rows[i].Cells[1].Value.ToString(),     //Poço
                            dgv_sondagem.Rows[i].Cells[4].Value.ToString(),     //Rodovia
                            dgv_sondagem.Rows[i].Cells[7].Value.ToString(),     //Trecho
                            dgv_sondagem.Rows[i].Cells[3].Value.ToString(),     //Longitude
                            dgv_sondagem.Rows[i].Cells[2].Value.ToString(),     //Latitude
                            dgv_sondagem.Rows[i].Cells[20].Value.ToString(),    //Nome Foto
                            dgv_sondagem.Rows[i].Cells[22].Value.ToString(),    //regional
                            dgv_sondagem.Rows[i].Cells[10].Value.ToString(),    //Camada 01
                            dgv_sondagem.Rows[i].Cells[11].Value.ToString(),    //Camada 02
                            dgv_sondagem.Rows[i].Cells[12].Value.ToString(),    //Camada 03
                            dgv_sondagem.Rows[i].Cells[13].Value.ToString(),    //Camada 04
                            dgv_sondagem.Rows[i].Cells[14].Value.ToString(),    //Espessura 01
                            dgv_sondagem.Rows[i].Cells[15].Value.ToString(),    //Espessura 02
                            dgv_sondagem.Rows[i].Cells[16].Value.ToString(),    //Espessura 03
                            dgv_sondagem.Rows[i].Cells[17].Value.ToString(),     //Espessura 04
                            dgv_sondagem.Rows[i].Cells[5].Value.ToString() + "," + dgv_sondagem.Rows[i].Cells[6].Value.ToString(), //KM,METROS
                            "word",
                            dgv_sondagem.Rows[i].Cells[23].Value.ToString() //Data Cadastro DiaMêsAno
                            );
                    }
                    load.btn_ok.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                load.btn_ok.Enabled = true;
            }
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }

        private void regionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DAL DbConnection = new DAL(localhost);
                ofd.Multiselect = true;
                ofd.Filter = " CSV |*.csv";
                Utilidade planilhaMain = new Utilidade();
                string regional;

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    if (ofd.FileName.Split('\\')[ofd.FileName.Split('\\').Length - 1] == "RegionalCamposGerais.csv")
                    {
                        regional = "Regional Campos Gerais";
                    }
                    else
                    {
                        regional = "Regional Leste";
                    }
                    foreach (string file in ofd.FileNames)
                    {
                        StreamReader csv = new StreamReader(file);
                        while ((linha = csv.ReadLine()) != null)
                        {
                            campo = linha.Split(';');
                            //*-------------------  UPDATE DADOS NO BANCO  ------------------------------*
                            DbConnection.updateRegionalBD(campo, regional, DbConnection);
                        }

                        if (!Directory.Exists(Path.GetDirectoryName(Path.GetDirectoryName(file) + "\\Concluido\\")))
                        {
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(file) + "\\Concluido\\");
                        }
                        csv.Close();
                        System.IO.File.Copy(file, (Path.GetDirectoryName(file) + "\\Concluido\\" + Path.GetFileName(file)));
                        System.IO.File.Delete(file);
                    }
                }
                atualizaGrid();
                ((IDisposable)DbConnection).Dispose();
                ((IDisposable)ofd).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DAL DbConnection = new DAL(localhost);
                ofd.Multiselect = true;
                ofd.Filter = " CSV |*.csv";
                Utilidade planilhaMain = new Utilidade();
                string dataDiaMesAno;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in ofd.FileNames)
                    {
                        StreamReader csv = new StreamReader(file);
                        while ((linha = csv.ReadLine()) != null)
                        {
                            campo = linha.Split(';');
                            dataDiaMesAno = campo[42].Split('_')[0];
                            //*-------------------  UPDATE DADOS NO BANCO  ------------------------------*
                            DbConnection.updateDataCadastroBD(campo, dataDiaMesAno, DbConnection);
                        }

                        if (!Directory.Exists(Path.GetDirectoryName(Path.GetDirectoryName(file) + "\\Concluido\\")))
                        {
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(file) + "\\Concluido\\");
                        }
                        csv.Close();
                        System.IO.File.Copy(file, (Path.GetDirectoryName(file) + "\\Concluido\\" + Path.GetFileName(file)));
                        System.IO.File.Delete(file);
                    }
                }
                atualizaGrid();
                ((IDisposable)DbConnection).Dispose();
                ((IDisposable)ofd).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dataNomeFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DAL DbConnection = new DAL(localhost);

                //LIMPAR A PLANILHA
                dgv_sondagem.Rows.Clear();
                grid = "";

                using (var conn = new NpgsqlConnection(DbConnection.GET()))
                {
                    Console.Out.WriteLine("Opening connection");
                    conn.Open();

                    var command = new NpgsqlCommand();
                    string comando = "SELECT * FROM public.sondagemdado where CHAR_LENGTH(data_cadastro) < 7";
                    command = new NpgsqlCommand(comando, conn);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        grid = string.Format(
                        reader.GetInt32(0).ToString() + ";" + reader.GetString(1) + ";" +
                        reader.GetString(2) + ";" + reader.GetString(3) + ";" +
                        reader.GetString(4) + ";" + reader.GetString(5) + ";" +
                        reader.GetString(6) + ";" + reader.GetString(7) + ";" +
                        reader.GetString(8) + ";" + reader.GetString(9) + ";" +
                        reader.GetString(10) + ";" + reader.GetString(11) + ";" +
                        reader.GetString(12) + ";" + reader.GetString(13) + ";" +
                        reader.GetString(14) + ";" + reader.GetString(15) + ";" +
                        reader.GetString(16) + ";" + reader.GetString(17) + ";" +
                        reader.GetString(18) + ";" + reader.GetString(19) + ";"
                        + reader.GetString(20));
                        campo = grid.Split(';');

                        nomeFoto = string.Format(reader.GetString(12));

                        string nomeFoto1 = nomeFoto.Split(';')[0];
                        string dataNomeFoto;

                        //CASO NO NOME DA FOTO NÃO TIVER A DATA DE REGISTRO
                        if (nomeFoto1.Split('_').Length < 6)
                            dataNomeFoto = "99";
                        else
                            dataNomeFoto = nomeFoto1.Split('_')[5];


                        dgv_sondagem.Rows.Add(
                            campo[0], //ID
                            campo[1], //Nome
                            campo[5], //Latitude
                            campo[6], //Longitude
                            campo[7], //Rodovia
                            campo[8], //KM
                            campo[9], //Metros
                            campo[10], //Trecho
                            campo[11], //Lote
                            campo[22], //Area
                            campo[23], //Camada 1
                            campo[24], //Camada 2
                            campo[25], //Camada 3
                            campo[26],  //Camada 4
                            campo[27],  //Espessura 1
                            campo[28],  //Espessura 2
                            campo[29],  //Espessura 3
                            campo[30],  //Espessura 4
                            campo[31],  //Status
                            campo[32],  //Observação
                            nomeFoto,
                            campo[33],  //Entrega
                            campo[34],   //regional
                            campo[35]   //data cadastro
                                        //grid[12] até grid[21] são nome das fotos 
                            );

                        string cmdAtualiza = String.Format("UPDATE sondagemdado SET data_cadastro='" + dataNomeFoto + "' WHERE id=" + campo[0]);

                        DbConnection.editarDatabase(cmdAtualiza, DbConnection);

                        Array.Clear(campo, 0, campo.Length);
                    }
                    reader.Close();
                    conn.Close();
                }
                ((IDisposable)DbConnection).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void kMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DAL DbConnection = new DAL(localhost);
                ofd.Multiselect = true;
                ofd.Filter = " CSV |*.csv";
                Utilidade planilhaMain = new Utilidade();
                string km;
                string metro;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in ofd.FileNames)
                    {
                        StreamReader csv = new StreamReader(file);
                        while ((linha = csv.ReadLine()) != null)
                        {
                            campo = linha.Split(';');
                            km = campo[3].Split('.')[0];
                            metro = campo[3].Split('.')[1];
                            //*-------------------  UPDATE DADOS NO BANCO  ------------------------------*
                            DbConnection.updateKmBD(campo, km, metro, DbConnection);
                        }

                        if (!Directory.Exists(Path.GetDirectoryName(Path.GetDirectoryName(file) + "\\Concluido\\")))
                        {
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(file) + "\\Concluido\\");
                        }
                        csv.Close();
                        System.IO.File.Copy(file, (Path.GetDirectoryName(file) + "\\Concluido\\" + Path.GetFileName(file)));
                        System.IO.File.Delete(file);
                    }
                }
                atualizaGrid();
                ((IDisposable)DbConnection).Dispose();
                ((IDisposable)ofd).Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void relátorioPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbdRelatorioWord = new FolderBrowserDialog();
                string pathRelatorio;

                if (fbdRelatorioWord.ShowDialog() == DialogResult.OK)
                {
                    pathRelatorio = fbdRelatorioWord.SelectedPath + "\\";
                    RelatorioWord relatorioWord = new RelatorioWord(pathRelatorio, caminhoFotoSalva);

                    /*Inicia o contador*/
                    if (load.firstTime == true)
                    {
                        load.maxCount_load(dgv_sondagem.Rows.Count - 1);
                        load.Show();
                    }

                    for (int i = 0; i < dgv_sondagem.Rows.Count - 1; i++)
                    {
                        load.loading();
                        relatorioWord.geraRelatorioWord(
                            caminhoWordSalva,
                            dgv_sondagem.Rows[i].Cells[8].Value.ToString(),     //Lote
                            dgv_sondagem.Rows[i].Cells[1].Value.ToString(),     //Poço
                            dgv_sondagem.Rows[i].Cells[4].Value.ToString(),     //Rodovia
                            dgv_sondagem.Rows[i].Cells[7].Value.ToString(),     //Trecho
                            dgv_sondagem.Rows[i].Cells[3].Value.ToString(),     //Longitude
                            dgv_sondagem.Rows[i].Cells[2].Value.ToString(),     //Latitude
                            dgv_sondagem.Rows[i].Cells[20].Value.ToString(),    //Nome Foto
                            dgv_sondagem.Rows[i].Cells[22].Value.ToString(),    //regional
                            dgv_sondagem.Rows[i].Cells[10].Value.ToString(),    //Camada 01
                            dgv_sondagem.Rows[i].Cells[11].Value.ToString(),    //Camada 02
                            dgv_sondagem.Rows[i].Cells[12].Value.ToString(),    //Camada 03
                            dgv_sondagem.Rows[i].Cells[13].Value.ToString(),    //Camada 04
                            dgv_sondagem.Rows[i].Cells[14].Value.ToString(),    //Espessura 01
                            dgv_sondagem.Rows[i].Cells[15].Value.ToString(),    //Espessura 02
                            dgv_sondagem.Rows[i].Cells[16].Value.ToString(),    //Espessura 03
                            dgv_sondagem.Rows[i].Cells[17].Value.ToString(),     //Espessura 04
                            dgv_sondagem.Rows[i].Cells[5].Value.ToString() + "," + dgv_sondagem.Rows[i].Cells[6].Value.ToString(), //KM,METROS
                            "pdf",
                            dgv_sondagem.Rows[i].Cells[23].Value.ToString() //Data Cadastro DiaMêsAno
                            );
                    }
                    load.btn_ok.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }

}