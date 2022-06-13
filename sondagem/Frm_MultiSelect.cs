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

namespace ProgFormularioEngenharia2
{
    public partial class Frm_MultiSelect : Form
    {
        private int count;
        private string[] filtro;
        private Frm_Principal formPrincipal = null;
        private string localhost;
        public Frm_MultiSelect(string[] filtro, Frm_Principal _princial)
        {
            this.count = 0;
            this.filtro = filtro;
            this.formPrincipal = _princial;
            InitializeComponent();
            fill_ComboBox();
        }

        private void Frm_MultiSelect_Load(object sender, EventArgs e){}

        private void fill_ComboBox()
        {
            cmbB_filtro.Text = "*";
            for (int i=0; i < this.filtro.Length; i++)
            {
                cmbB_filtro.Items.Add(this.filtro[i]);
            }
        }

        public void fill_Grid(int id, string nome, string entrega)
        {
            dgv_multiselectSondagem.Rows.Add(id, nome, entrega);
        }
        private void btn_mudarEntrega_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgv_multiselectSondagem.GetCellCount(DataGridViewElementStates.Selected);
            
            if (selectedCellCount > 0)
            {
                if (dgv_multiselectSondagem.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < selectedCellCount; i = i + 3)
                    {
                        sb.Append("Row: ");
                        sb.Append(dgv_multiselectSondagem.SelectedCells[i].RowIndex.ToString());
                        sb.Append(", Column: ");
                        sb.Append(dgv_multiselectSondagem.SelectedCells[i].ColumnIndex.ToString());
                        
                        //dgv_sondagem.Rows[i].Cells[1].Value.ToString();
                        //filtro = cmbB_Lotes.SelectedItem.ToString();
                        dgv_multiselectSondagem.SelectedCells[i + 2].Value = cmbB_filtro.SelectedItem.ToString();

                        sb.Append(", Value: ");
                        sb.Append(dgv_multiselectSondagem.SelectedCells[i+2].Value.ToString());

                        sb.Append(Environment.NewLine);
                        count++;
                    }

                    sb.Append("Total: " + count);
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }

        private void btn_salvarEntrega_Click(object sender, EventArgs e)
        {
            loadConfig();

            Int32 selectedCellCount = dgv_multiselectSondagem.GetCellCount(DataGridViewElementStates.Selected);
            int idMultiselect;
            DAL DbConnection = new DAL(localhost);
            string cmdAtualiza;

            for (int i = 0; i < selectedCellCount; i = i + 3)
            {
                Console.WriteLine(dgv_multiselectSondagem.SelectedCells[i].Value);

                idMultiselect = Convert.ToInt32(dgv_multiselectSondagem.SelectedCells[i].Value.ToString());

                for (int j = 0; j < formPrincipal.dgv_sondagem.Rows.Count - 1; j++)
                {
                    if (Convert.ToInt32(formPrincipal.dgv_sondagem.Rows[j].Cells[0].Value.ToString()) == idMultiselect)
                    {
                        Console.WriteLine("FORM PRINCIPAL :" + Convert.ToInt32(formPrincipal.dgv_sondagem.Rows[j].Cells[0].Value.ToString()) + " ----- FORM MULTISELECT: " + dgv_multiselectSondagem.SelectedCells[i + 2].Value);

                        formPrincipal.dgv_sondagem.Rows[j].Cells[21].Value = dgv_multiselectSondagem.SelectedCells[i + 2].Value;
                        cmdAtualiza = String.Format("UPDATE sondagemdado SET entrega='" + dgv_multiselectSondagem.SelectedCells[i + 2].Value + "' WHERE id=" + idMultiselect);
                        DbConnection.editarDatabase(cmdAtualiza, DbConnection);
                    }           
                }
            }
            formPrincipal.atualizaGrid();
            this.Close();
            
        }

        private void loadConfig()
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
    }
}
