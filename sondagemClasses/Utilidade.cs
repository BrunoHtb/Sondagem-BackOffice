using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgFormularioEngenharia2
{
    public class Utilidade
    {
        private string _caminhoSelecionadoPlanilha;
        private string _arquivoLote;
        private string[] _cabecalho = { "Item", "Nome", "Latitude Prevista", "Longitude Prevista", "Login", "Latitude", "Longitude", "Rodovia", "Km", "Metro", "Trecho",
                                        "Lote", "Foto 1", "Caminho Foto 1", "Foto 2", "Caminho Foto 2", "Foto 3", "Caminho Foto 3", "Foto 4", "Caminho Foto 4",
                                        "Foto 5", "Caminho Foto 5", "Foto 6", "Caminho Foto 6", "Foto 7", "Caminho Foto 7", "Foto 8", "Caminho Foto 8",
                                        "Foto 9", "Caminho Foto 9", "Foto 10", "Caminho Foto 10", "Area", "Camda 1", "Camda 2", "Camda 3", "Camda 4", "Espessura 1",
                                        "Espessura 2", "Espessura 3", "Espessura 4", "Status", "Data Coleta", "Observacao", " " };

        public Utilidade() { }

        ~Utilidade() { }
        public List<string> CaminhoPlanilha()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                this._caminhoSelecionadoPlanilha = fbd.SelectedPath.Replace("\\", "/") + "/";
                try
                {
                    //Console.WriteLine(_caminhoSelecionadoPlanilha.Replace("\\", "/"));
                    List<string> _Arqs = new List<string>();
                    _Arqs.AddRange(System.IO.Directory.GetFiles(_caminhoSelecionadoPlanilha, "*.csv", System.IO.SearchOption.TopDirectoryOnly));
                    return _Arqs;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void moverPlanilha()
        {
            List<string> args = CaminhoPlanilha();
            try
            {
                if (args != null)
                {
                    foreach (string arq in args)
                    {
                        moverPlanilhaDir(arq);
                    }

                    MessageBox.Show("SUCESSO", "Esteio Sondagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void moverPlanilhaDir(string _arquivo)
        {
            try
            {
                string[] _splitNomeArquivo = _arquivo.Split('/');
                string nomeArq = _splitNomeArquivo[_splitNomeArquivo.Length - 1];
                string pathSubDir = _caminhoSelecionadoPlanilha + "_Planilhas/";

                if (!Directory.Exists(pathSubDir))
                {
                    System.IO.Directory.CreateDirectory(pathSubDir);
                    System.IO.File.Copy(_arquivo, pathSubDir+ nomeArq, true);
                    System.IO.File.Delete(_arquivo);
                }
                else
                {
                    System.IO.File.Copy(_arquivo, pathSubDir + nomeArq, true);
                    System.IO.File.Delete(_arquivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int valorClicadoFoto(string selected)
        {
            switch (selected)
            {
                case "PANORÂMICA":
                    return 0;

                case "CAMADAS":
                    return 1;

                case "FINAL FURO":
                    return 2;

                case "AMOSTRAS":
                    return 3;

                case "FURO FECHADO":
                    return 4;

                case "BOLETIM":
                    return 5;

                case "SITU 01":
                    return 6;

                case "SITU 02":
                    return 7;

                case "SITU 03":
                    return 8;

                case "SITU 04":
                    return 9;
            }
            return -1;
        }

    }
}
