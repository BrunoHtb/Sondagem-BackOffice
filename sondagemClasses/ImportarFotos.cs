using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProgFormularioEngenharia2
{
    public partial class ImportarFotos
    {
        string caminhoSelecionadoOrgFoto;
        string caminhoFotoSalva;

        public ImportarFotos(string caminho)
        {
            this.caminhoFotoSalva = caminho;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<string> CaminhoFoto()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.caminhoSelecionadoOrgFoto = fbd.SelectedPath.Replace("\\", "/") + "/";
                try
                {
                    List<string> _Arqs = new List<string>();
                    _Arqs.AddRange(System.IO.Directory.GetFiles(caminhoSelecionadoOrgFoto, "*.jpg", System.IO.SearchOption.TopDirectoryOnly));
                    
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

        public void moverFoto()
        {
            List<string> args = CaminhoFoto();
            try
            {
                if (args != null)
                {
                    foreach (string arq in args)
                    {
                        moverFotoDir(arq);
                    }
                    MessageBox.Show("SUCESSO", "Esteio Sondagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string returnPathImgFull(List<string> listArq, string caminho)
        {
            string nomeArq = null;
            foreach (string arq in listArq)
            {
                if(arq != null)
                {
                    nomeArq = arq;
                    break;
                }
            }
            if(nomeArq == null)
            {
                return null;
            }
            else
            {
                string[] _splitNomeArquivo = nomeArq.Split('\\');
                string[] nomeDir = _splitNomeArquivo[_splitNomeArquivo.Length - 1].Split('_');
                string pathImg = caminho + nomeDir[0] + "_" + nomeDir[1] + "_" + nomeDir[2];

                return pathImg;
            }
        }

        void moverFotoDir(string _arquivo)
        {
            try
            {
                string[] _splitNomeArquivo = _arquivo.Split('/');
                string[] nomeDir = _splitNomeArquivo[_splitNomeArquivo.Length - 1].Split('_');
                string pathSubDir = caminhoSelecionadoOrgFoto + nomeDir[0] + "_" + nomeDir[1] + "_" + nomeDir[2] + "/";

                if (!Directory.Exists(pathSubDir))
                {
                    System.IO.Directory.CreateDirectory(pathSubDir);
                    System.IO.File.Copy(_arquivo, pathSubDir + _splitNomeArquivo[_splitNomeArquivo.Length - 1], true);
                    System.IO.File.Delete(_arquivo);
                }
                else
                {
                    System.IO.File.Copy(_arquivo, pathSubDir + _splitNomeArquivo[_splitNomeArquivo.Length - 1], true);
                    System.IO.File.Delete(_arquivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> viewFoto(string nome)
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(20, 20);
            List<string> img = new List<string>();
               
            try
            {
                string[] listaFoto = nome.Split(';');
                string[] nomePonto = listaFoto[0].Split('_');
                string subDir = caminhoFotoSalva + caminhoSelecionadoOrgFoto + nomePonto[0] + "_" + nomePonto[1] + "_" + nomePonto[2] + "\\";

                if (Directory.Exists(subDir))
                {
                    string[] arquivos = Directory.GetFiles(subDir);

                    //Retorna lista de IMG em ordem
                    img = lastFoto(arquivos);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi encontrado o SUBDIRETORIO\n\r" + ex.Message);
            }
            return img;
        }

        public List<string> lastFoto(string[] arquivos)
        {
            List<string> img = new List<string>();
            string[] aux;
            string[] parteNomeFoto;
            string[] sortImage = new string[10];
            string nomeFoto, ultimoParte, penultimaParte;           
            int valorFoto;
            
            for (int i = 0; i < sortImage.Length; i++)
            {
                sortImage[i] = null;
            }
            foreach (string arq in arquivos)
            {
                aux = arq.Split('/');
                nomeFoto = aux[aux.Length - 1];
                parteNomeFoto = nomeFoto.Split('_');

                ultimoParte = parteNomeFoto[parteNomeFoto.Length - 1].Split('.')[0];
                penultimaParte = parteNomeFoto[parteNomeFoto.Length - 2];

                if (penultimaParte.Length != 1 && ultimoParte.Length <= 2)
                {  
                    valorFoto = Int32.Parse(ultimoParte);
                    sortImage[valorFoto - 1] = arq;                 
                }
                else if(penultimaParte.Length == 1 && ultimoParte.Length <= 2)
                {
                    valorFoto = Int32.Parse(penultimaParte);

                    if (sortImage[valorFoto-1] == null)
                    {
                        sortImage[valorFoto - 1] = arq;
                    }
                    else
                    {
                        if (pegarUltimodigitoFoto(sortImage[valorFoto-1]) < Int32.Parse(ultimoParte))
                        {
                            sortImage[valorFoto - 1] = arq;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            //Adiciona na Lista ordenado
            for (int i = 0; i < sortImage.Length; i++)
            {
                if(sortImage[i] != null)
                {
                    img.Add(sortImage[i]);
                }
                else
                {
                    img.Add(null);
                }
            }
            return img;
        }

        public int pegarUltimodigitoFoto(string arquivos)
        {
            string[] aux;
            string[] parteNomeFoto;
            string nomeFoto;
            int valorFoto;

            aux = arquivos.Split('/');
            nomeFoto = aux[aux.Length - 1];
            parteNomeFoto = nomeFoto.Split('_');
            valorFoto = Int32.Parse(parteNomeFoto[parteNomeFoto.Length - 1].Split('.')[0]);
      
            return valorFoto;
        } 


    }
}

