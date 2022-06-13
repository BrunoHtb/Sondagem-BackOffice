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
    public partial class Frm_Configuração : Form
    {
        private string caminhoSelecionado;
        
        public Frm_Configuração(string ipBanco, string folderImage, string folderWord)
        {
            InitializeComponent();

            txtB_ipBancoDado.Text = ipBanco;
            txtB_folderImage.Text = folderImage;
            txtB_wordDocument.Text = folderWord;
        }

        private void btn_folderImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            try
            {
                this.caminhoSelecionado = fbd.SelectedPath+ "\\";
                if (result == DialogResult.OK)
                {
                    txtB_folderImage.Text = caminhoSelecionado;
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void btn_salvarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(".\\Config.txt"))
                {
                    File.WriteAllText(".\\Config.txt", txtB_ipBancoDado.Text + "\n" + txtB_folderImage.Text + "\n" + txtB_wordDocument.Text);
                    MessageBox.Show("Configurações salvas");
                }
            }
            catch
            {}
        }

        private void btn_fecharConfig_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_folderWord_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            try
            {
                this.caminhoSelecionado = fbd.SelectedPath + "\\";
                if (result == DialogResult.OK)
                {
                    txtB_wordDocument.Text = caminhoSelecionado;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
