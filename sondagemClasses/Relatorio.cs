using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Npgsql;
using ProgFormularioEngenharia2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using XlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;

namespace ProgFormularioEngenharia2
{
    class Relatorio
    {
        public string caminhoRelatorioSalva;
        public string caminhoFotoSalva;
        public string localhost;
        public string[,] campoRe;
        string grid;
        string filtroLote;
        string filtroEntrega;
        string filtroEntregaBarra;
        Int64 countRows;
        Frm_loading load = new Frm_loading();

        public Relatorio(string filtroLote, string filtroEntrega, string localhost, string caminhoFotoSalva)
        {
            this.filtroLote = filtroLote;
            this.filtroEntrega = filtroEntrega;
            this.localhost = localhost;
            this.caminhoFotoSalva = caminhoFotoSalva;
            AjustarFiltroEntrega();
        }

        private void AjustarFiltroEntrega()
        {
            this.filtroEntregaBarra = this.filtroEntrega;
            if (this.filtroEntrega != "*" && this.filtroEntrega != "null")
            {
                this.filtroEntrega = (this.filtroEntrega.Split('/')[0] + this.filtroEntrega.Split('/')[1]);
            }
        }

        public void GerarRelatorioParcial()
        {
            try
            {
                FolderBrowserDialog fbd_Relatorio = new FolderBrowserDialog();

                if (fbd_Relatorio.ShowDialog() == DialogResult.OK)
                {
                    caminhoRelatorioSalva = fbd_Relatorio.SelectedPath + "\\";
                }
                else return;

                #region Exportando para XLS
                Microsoft.Office.Interop.Excel._Application _excelApp; // cria uma aplicação
                Microsoft.Office.Interop.Excel._Workbook _excelWorkBook; // aqui vc cria uma pasta de trabalho
                Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet = null; // aqui vc cria a aba

                //inicio parametros das funcoes do excel
                _excelApp = new Microsoft.Office.Interop.Excel.Application(); // criando instancia do excel
                _excelWorkBook = _excelApp.Workbooks.Add(Type.Missing);
                _excelWorkSheet = _excelWorkBook.Sheets[1]; // criando planilha na pasta de trabalho
                _excelWorkSheet = _excelWorkBook.ActiveSheet;
                _excelWorkSheet.Columns.AutoFit();
                _excelWorkSheet.PageSetup.Zoom = 70;
                _excelWorkSheet.Name = "Resultado_1";
                _excelWorkSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                Microsoft.Office.Interop.Excel.Range cells = _excelWorkBook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                cells.VerticalAlignment = XlHAlign.xlHAlignCenter;
                cells.EntireColumn.AutoFit();
                cells.Font.Name = "Arial";
                cells.Font.Size = 10;
                // fim dos parametros das funcoes do excel

                //_excelApp.Visible = true;

                //Gerando Cabeçalho
                primeiraParteCabecalho(_excelWorkSheet);
                cabecalhoFoto(_excelWorkSheet, 8);
                connectionBDParcial();

                /*Inicia o contador*/
                if (load.firstTime == true)
                {
                    load.maxCount_load(Convert.ToInt32(countRows));
                    load.Show();
                }

                int index = 1;
                for (int rows = 0; rows < countRows; rows++)
                {
                    load.loading();
                    for (int datagridColumns = 0; datagridColumns < 18; datagridColumns++)
                    {
                        if (datagridColumns == 0)
                        {
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1] = index;
                        }
                        else if (datagridColumns >= 7 && campoRe[rows, 6] != ";;;;;;;;;")
                        {
                            Microsoft.Office.Interop.Excel.Range imgoRange = (Microsoft.Office.Interop.Excel.Range)_excelWorkSheet.Cells[rows + 3, datagridColumns + 1];
                            ImportarFotos img = new ImportarFotos(caminhoFotoSalva);
                            List<string> nomefotos = img.viewFoto(campoRe[rows, 6]);
                            string subDir = img.returnPathImgFull(nomefotos, caminhoFotoSalva);
                            float Left = (float)((double)imgoRange.Left) + 20;
                            float Top = (float)((double)imgoRange.Top) + 25;
                            const float ImageSize = 280;

                            _excelWorkSheet.Rows.EntireRow[rows + 3].RowHeight = 200;
                            _excelWorkSheet.Columns[datagridColumns + 1].ColumnWidth = 60;
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1].VerticalAlignment = XlHAlign.xlHAlignCenter;
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;

                            //----------------------------------------------------------------------------------------------------------------------------------------
                            if (Directory.Exists(subDir) && subDir != null)
                            {
                                //7
                                if (datagridColumns + 1 == 8)
                                {
                                    if (File.Exists(nomefotos[0]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[0], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //8
                                else if (datagridColumns + 1 == 9)
                                {
                                    if (File.Exists(nomefotos[1]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[1], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //9
                                else if (datagridColumns + 1 == 10)
                                {
                                    if (File.Exists(nomefotos[2]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[2], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //10
                                else if (datagridColumns + 1 == 11)
                                {
                                    if (File.Exists(nomefotos[3]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[3], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //11
                                else if (datagridColumns + 1 == 12)
                                {
                                    if (File.Exists(nomefotos[4]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[4], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //12
                                else if (datagridColumns + 1 == 13)
                                {
                                    if (File.Exists(nomefotos[5]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[5], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //13
                                else if (datagridColumns + 1 == 14)
                                {
                                    if (File.Exists(nomefotos[6]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[6], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //14
                                else if (datagridColumns + 1 == 15)
                                {
                                    if (File.Exists(nomefotos[7]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[7], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //15
                                else if (datagridColumns + 1 == 16)
                                {
                                    if (File.Exists(nomefotos[8]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[8], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //16
                                else if (datagridColumns + 1 == 17)
                                {
                                    if (File.Exists(nomefotos[9]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[9], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                            }
                            
                            img.Dispose();
                            //--------------------------------------------------------------------------------------------------------------------------------------------
                        }
                        else if (datagridColumns < 7)
                        {
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1] = campoRe[rows, datagridColumns - 1];
                        }
                        else
                        {
                            continue;
                        }
                        _excelWorkSheet.Cells[rows + 3, datagridColumns + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                    }
                    index++;
                }

                //Diretorio que vai ser salvo
                string nomeFile = nomeFileXLS(this.filtroLote, this.filtroEntrega);
                _excelWorkBook.SaveAs(caminhoRelatorioSalva + nomeFile + "_Parcial", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                #endregion

                _excelWorkBook.Close();
                _excelApp.Quit();
                load.btn_ok.Enabled = true;
                Array.Clear(campoRe, 0, campoRe.Length);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void GerarRelatorioCompleto()
        {
            try
            {
                FolderBrowserDialog fbd_Relatorio = new FolderBrowserDialog();

                if (fbd_Relatorio.ShowDialog() == DialogResult.OK)
                {
                    caminhoRelatorioSalva = fbd_Relatorio.SelectedPath + "\\";
                }
                else return;

                #region Exportando para XLS
                Microsoft.Office.Interop.Excel._Application _excelApp; // cria uma aplicação
                Microsoft.Office.Interop.Excel._Workbook _excelWorkBook; // aqui vc cria uma pasta de trabalho
                Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet = null; // aqui vc cria a aba

                //inicio parametros das funcoes do excel
                _excelApp = new Microsoft.Office.Interop.Excel.Application(); // criando instancia do excel
                _excelWorkBook = _excelApp.Workbooks.Add(Type.Missing);
                _excelWorkSheet = _excelWorkBook.Sheets[1]; // criando planilha na pasta de trabalho
                _excelWorkSheet = _excelWorkBook.ActiveSheet;
                _excelWorkSheet.Columns.AutoFit();
                _excelWorkSheet.PageSetup.Zoom = 70;
                _excelWorkSheet.Name = "Resultado_1";
                _excelWorkSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                Microsoft.Office.Interop.Excel.Range cells = _excelWorkBook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                cells.VerticalAlignment = XlHAlign.xlHAlignCenter;
                cells.EntireColumn.AutoFit();
                cells.Font.Name = "Arial";
                cells.Font.Size = 10;
                // fim dos parametros das funcoes do excel

                //_excelApp.Visible = true;

                primeiraParteCabecalho(_excelWorkSheet);
                segundaParteCabecalho(_excelWorkSheet, 8);
                cabecalhoFoto(_excelWorkSheet, 14);
                connectionBDCompleto();

                /*Inicia o contador*/
                if (load.firstTime == true)
                {
                    load.maxCount_load(Convert.ToInt32(countRows));
                    load.Show();
                }

                int index = 1;
                int cellRows = 3;
                for (int rows = 0; rows < countRows; rows++)
                {
                    load.loading();
                    for (int datagridColumns = 0; datagridColumns < 23; datagridColumns++)
                    {
                        int cellColumn = datagridColumns + 1;
                        if (datagridColumns == 0)
                        {
                            _excelWorkSheet.Cells[cellRows, cellColumn] = index;
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[cellRows, cellColumn], _excelWorkSheet.Cells[cellRows + 3, cellColumn]].Merge();
                        }
                        else if (datagridColumns >= 13 && campoRe[rows, 12] != ";;;;;;;;;")
                        {
                            Microsoft.Office.Interop.Excel.Range imgoRange = (Microsoft.Office.Interop.Excel.Range)_excelWorkSheet.Cells[cellRows, cellColumn];
                            ImportarFotos img = new ImportarFotos(caminhoFotoSalva);
                            List<string> nomefotos = img.viewFoto(campoRe[rows, 12]);
                            string subDir = img.returnPathImgFull(nomefotos, caminhoFotoSalva);
                            float Left = (float)((double)imgoRange.Left) + 20;
                            float Top = (float)((double)imgoRange.Top) + 25;
                            const float ImageSize = 280;

                            _excelWorkSheet.Range[_excelWorkSheet.Cells[cellRows, cellColumn], _excelWorkSheet.Cells[cellRows + 3, cellColumn]].Merge();

                            _excelWorkSheet.Rows.EntireRow[cellRows].RowHeight = 200;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Columns[cellColumn].ColumnWidth = 60;
                            _excelWorkSheet.Cells[cellRows, cellColumn].VerticalAlignment = XlHAlign.xlHAlignCenter;
                            _excelWorkSheet.Cells[cellRows, cellColumn].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            //----------------------------------------------------------------------------------------------------------------------------------------
                            if (Directory.Exists(subDir) && subDir != null)
                            {
                                //7
                                if (cellColumn == 13)
                                {
                                    if (File.Exists(nomefotos[0]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[0], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //8
                                else if (cellColumn == 14)
                                {
                                    if (File.Exists(nomefotos[1]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[1], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //9
                                else if (cellColumn == 15)
                                {
                                    if (File.Exists(nomefotos[2]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[2], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //10
                                else if (cellColumn == 16)
                                {
                                    if (File.Exists(nomefotos[3]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[3], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //11
                                else if (cellColumn == 17)
                                {
                                    if (File.Exists(nomefotos[4]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[4], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //12
                                else if (cellColumn == 18)
                                {
                                    if (File.Exists(nomefotos[5]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[5], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //13
                                else if (cellColumn == 19)
                                {
                                    if (File.Exists(nomefotos[6]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[6], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //14
                                else if (cellColumn == 20)
                                {
                                    if (File.Exists(nomefotos[7]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[7], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //15
                                else if (cellColumn == 21)
                                {
                                    if (File.Exists(nomefotos[8]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[8], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                                //16
                                else if (cellColumn == 22)
                                {
                                    if (File.Exists(nomefotos[9]))
                                    {
                                        _excelWorkSheet.Shapes.AddPicture(nomefotos[9], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                    }
                                }
                            }
                            img.Dispose();
                            //--------------------------------------------------------------------------------------------------------------------------------------------
                        }
                        else if (datagridColumns == 10 || datagridColumns == 11) //Preenche celulas de CAMADA E ESPESSURA
                        {
                            string[] cellsItem = campoRe[rows, datagridColumns].Split(';');

                            _excelWorkSheet.Rows.EntireRow[cellRows].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(cellRows + 1)].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(cellRows + 2)].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(cellRows + 3)].RowHeight = 45;  //Aumenta o tamanho da linha

                            _excelWorkSheet.Cells[cellRows, cellColumn] = cellsItem[0];
                            _excelWorkSheet.Cells[(cellRows + 1), cellColumn] = cellsItem[1];
                            _excelWorkSheet.Cells[(cellRows + 2), cellColumn] = cellsItem[2];
                            _excelWorkSheet.Cells[(cellRows + 3), cellColumn] = cellsItem[3];
                        }
                        else if (datagridColumns < 10) //Preenche celula de dos dados 
                        {
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[cellRows, cellColumn], _excelWorkSheet.Cells[cellRows + 3, cellColumn]].Merge();
                            _excelWorkSheet.Cells[cellRows, cellColumn] = campoRe[rows, datagridColumns - 1];
                        }
                        else if (datagridColumns == 12) //Preenche celula de OBSERVAÇÃO
                        {
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[cellRows, cellColumn], _excelWorkSheet.Cells[cellRows + 3, cellColumn]].Merge();
                            _excelWorkSheet.Cells[cellRows, cellColumn] = campoRe[rows, 9];
                        }
                        else
                        {
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[cellRows, cellColumn], _excelWorkSheet.Cells[cellRows + 3, cellColumn]].Merge();
                        }
                        _excelWorkSheet.Cells[cellRows, cellColumn].Borders.LineStyle = XlLineStyle.xlContinuous;
                        _excelWorkSheet.Cells[cellRows + 1, cellColumn].Borders.LineStyle = XlLineStyle.xlContinuous;
                        _excelWorkSheet.Cells[cellRows + 2, cellColumn].Borders.LineStyle = XlLineStyle.xlContinuous;
                        _excelWorkSheet.Cells[cellRows + 3, cellColumn].Borders.LineStyle = XlLineStyle.xlContinuous;
                    }
                    cellRows += 4;
                    index++;
                }

                //Diretorio que vai ser salvo
                string nomeFile = nomeFileXLS(this.filtroLote, this.filtroEntrega);
                _excelWorkBook.SaveAs(caminhoRelatorioSalva + nomeFile + "_Completo", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                #endregion

                _excelWorkBook.Close();
                _excelApp.Quit();
                load.btn_ok.Enabled = true;
                Array.Clear(campoRe, 0, campoRe.Length);
            }
            catch (Exception ex)
            {

            }
        }

        public void GerarRelatorioParcialSemFotos()
        {
            try
            {
                FolderBrowserDialog fbd_Relatorio = new FolderBrowserDialog();

                if (fbd_Relatorio.ShowDialog() == DialogResult.OK)
                {
                    caminhoRelatorioSalva = fbd_Relatorio.SelectedPath + "\\";
                }
                else return;

                #region Exportando para XLS
                Microsoft.Office.Interop.Excel._Application _excelApp; // cria uma aplicação
                Microsoft.Office.Interop.Excel._Workbook _excelWorkBook; // aqui vc cria uma pasta de trabalho
                Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet = null; // aqui vc cria a aba

                //inicio parametros das funcoes do excel
                _excelApp = new Microsoft.Office.Interop.Excel.Application(); // criando instancia do excel
                _excelWorkBook = _excelApp.Workbooks.Add(Type.Missing);
                _excelWorkSheet = _excelWorkBook.Sheets[1]; // criando planilha na pasta de trabalho
                _excelWorkSheet = _excelWorkBook.ActiveSheet;
                _excelWorkSheet.Columns.AutoFit();
                _excelWorkSheet.PageSetup.Zoom = 70;
                _excelWorkSheet.Name = "Resultado_1";
                _excelWorkSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                Microsoft.Office.Interop.Excel.Range cells = _excelWorkBook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                cells.VerticalAlignment = XlHAlign.xlHAlignCenter;
                cells.EntireColumn.AutoFit();
                cells.Font.Name = "Arial";
                cells.Font.Size = 10;
                // fim dos parametros das funcoes do excel

                //_excelApp.Visible = true;

                //Gerando Cabeçalho
                CabecalhoSemFoto(_excelWorkSheet);
                connectionBDSemFotos();

                /*Inicia o contador*/
                if (load.firstTime == true)
                {
                    load.maxCount_load(Convert.ToInt32(countRows));
                    load.Show();
                }

                int index = 1;
                int rows = 0;
                for (int line = 0; line < countRows; line++)
                {
                    load.loading();
                    for (int datagridColumns = 0; datagridColumns < 9; datagridColumns++)
                    {
                        if (datagridColumns == 0)
                        {
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1] = index;
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[rows + 3, datagridColumns + 1], _excelWorkSheet.Cells[rows + 6, datagridColumns + 1]].Merge();
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[rows + 3, datagridColumns + 1], _excelWorkSheet.Cells[rows + 6, datagridColumns + 1]].Borders.LineStyle = XlLineStyle.xlContinuous;
                        }
                        else if (datagridColumns == 6 || datagridColumns == 7) //Preenche celulas de CAMADA E ESPESSURA
                        {  
                            string[] cellsItem = campoRe[line, datagridColumns - 1].Split(';');

                            _excelWorkSheet.Rows.EntireRow[(rows + 3)].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(rows + 4)].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(rows + 5)].RowHeight = 45;  //Aumenta o tamanho da linha
                            _excelWorkSheet.Rows.EntireRow[(rows + 6)].RowHeight = 45;  //Aumenta o tamanho da linha

                            _excelWorkSheet.Cells[(rows + 3), datagridColumns + 1] = cellsItem[0];
                            _excelWorkSheet.Cells[(rows + 4), datagridColumns + 1] = cellsItem[1];
                            _excelWorkSheet.Cells[(rows + 5), datagridColumns + 1] = cellsItem[2];
                            _excelWorkSheet.Cells[(rows + 6), datagridColumns + 1] = cellsItem[3];
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                            _excelWorkSheet.Cells[rows + 4, datagridColumns + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                            _excelWorkSheet.Cells[rows + 5, datagridColumns + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                            _excelWorkSheet.Cells[rows + 6, datagridColumns + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                        }
                        
                        else
                        {
                            _excelWorkSheet.Cells[rows + 3, datagridColumns + 1] = campoRe[line, datagridColumns - 1];
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[rows + 3, datagridColumns + 1], _excelWorkSheet.Cells[rows + 6, datagridColumns + 1]].Merge();
                            _excelWorkSheet.Range[_excelWorkSheet.Cells[rows + 3, datagridColumns + 1], _excelWorkSheet.Cells[rows + 6, datagridColumns + 1]].Borders.LineStyle = XlLineStyle.xlContinuous;
                        }
                    }
                    rows += 4;
                    index++;
                }

                //Diretorio que vai ser salvo
                string nomeFile = nomeFileXLS(this.filtroLote, this.filtroEntrega);
                _excelWorkBook.SaveAs(caminhoRelatorioSalva + nomeFile + "_Sem_Fotos", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                #endregion

                _excelWorkBook.Close();
                _excelApp.Quit();
                load.btn_ok.Enabled = true;
                Array.Clear(campoRe, 0, campoRe.Length);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private string comandoBDCount()
        {
            string comandoCount;

            if (this.filtroLote == "*" && this.filtroEntrega == "*")
            {
                comandoCount = "SELECT COUNT(*) FROM sondagemdado";
            }
            else if (this.filtroLote == "*" && this.filtroEntrega != "*")
            {
                comandoCount = "SELECT COUNT(*) FROM sondagemdado WHERE entrega = '" + this.filtroEntregaBarra + "'";
            }
            else if (this.filtroLote != "*" && this.filtroEntrega == "*")
            {
                comandoCount = "SELECT COUNT(*) FROM sondagemdado WHERE lote = '" + this.filtroLote + "'";
            }
            else
            {
                comandoCount = "SELECT COUNT(*) FROM sondagemdado WHERE lote = '" + this.filtroLote + "' AND entrega = '" + this.filtroEntregaBarra + "'";
            }

            return comandoCount;
        }

        private string comandoBDRelatorioParcial()
        {
            string comando;

            if (this.filtroLote == "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, foto FROM sondagemdado ORDER BY nome";
            }
            else if (this.filtroLote == "*" && this.filtroEntrega != "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, foto FROM sondagemdado WHERE entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome";
            }
            else if (this.filtroLote != "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, foto FROM sondagemdado WHERE lote = '" + this.filtroLote + "' ORDER BY nome";
            }
            else
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, foto FROM sondagemdado WHERE lote = '" + this.filtroLote + "' AND entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome ";
            }
            return comando;
        }

        private string comandoBDRelatorioCompleto()
        {
            string comando;

            if (this.filtroLote == "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, metro, lote, area, observacao, camada, espessura, foto FROM sondagemdado ORDER BY nome";
            }
            else if (this.filtroLote == "*" && this.filtroEntrega != "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, metro, lote, area, observacao, camada, espessura, foto FROM sondagemdado WHERE entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome";
            }
            else if (this.filtroLote != "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, metro, lote, area, observacao, camada, espessura, foto FROM sondagemdado WHERE lote = '" + this.filtroLote + "' ORDER BY nome";
            }
            else
            {
                comando = "SELECT nome, latitude, longitude, km, rodovia, trecho, metro, lote, area, observacao, camada, espessura, foto FROM sondagemdado WHERE lote = '" + this.filtroLote + "' AND entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome ";
            }
            return comando;
        }

        private string comandoBDRelatorioSemFotos()
        {
            string comando;

            if (this.filtroLote == "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, rodovia, trecho, camada, espessura, observacao FROM sondagemdado ORDER BY nome";
            }
            else if (this.filtroLote == "*" && this.filtroEntrega != "*")
            {
                comando = "SELECT nome, latitude, longitude, rodovia, trecho, camada, espessura, observacao FROM sondagemdado WHERE entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome";
            }
            else if (this.filtroLote != "*" && this.filtroEntrega == "*")
            {
                comando = "SELECT nome, latitude, longitude, rodovia, trecho, camada, espessura, observacao FROM sondagemdado WHERE lote = '" + this.filtroLote + "' ORDER BY nome";
            }
            else
            {
                comando = "SELECT nome, latitude, longitude, rodovia, trecho, camada, espessura, observacao FROM sondagemdado WHERE lote = '" + this.filtroLote + "' AND entrega = '" + this.filtroEntregaBarra + "' ORDER BY nome ";
            }
            return comando;
        }

        private string nomeFileXLS(string lote, string entrega)
        {
            string nomeFile;
            if (lote == "*" && entrega == "*")
            {
                nomeFile = "Relatorio_" + "lote_entrega";
            }
            else if (lote != "*" && entrega == "*")
            {
                nomeFile = "Relatorio_" + lote + "_entrega";
            }
            else if (lote == "*" && entrega != "*")
            {
                nomeFile = "Relatorio_lote_" + entrega;
            }
            else
            {
                nomeFile = "Relatorio_" + lote + "_" + entrega;
            }
            return nomeFile;
        }

        private void configuracaoCelulaCabecalho(Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet, int column, int line)
        {
            _excelWorkSheet.Cells[line, column].HorizontalAlignment = XlHAlign.xlHAlignCenter; // add alinhamento horizontal da célula
            _excelWorkSheet.Cells[line, column].VerticalAlignment = XlHAlign.xlHAlignCenter; // add alinhamento vertical da célula
            _excelWorkSheet.Cells[line, column].Font.Bold = true; // add a célula fonte negrito
            _excelWorkSheet.Cells[line, column].RowHeight = 20; // add altura da célula
            _excelWorkSheet.Cells[line, column].ColumnWidth = 20; // add largura da célula
            _excelWorkSheet.Cells[line, column].Font.Size = 12; // add tamanho da font
        }

        private void primeiraParteCabecalho(Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet)
        {
            string[] cabecalho = { "Item", "PI", "Coord.", "Latitude", "Longitude", "Km", "Rod.", "Trecho", "Camadas", "Espessuras" };
            int column = 1;
            for (int i = 1; i <= 7; i++)
            {
                if (i == 3)
                {
                    _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i], _excelWorkSheet.Cells[1, (i + 1)]].Merge();
                    i = i + 1;
                }
                else
                {
                    _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i], _excelWorkSheet.Cells[2, i]].Merge();
                }
            }

            bool afterCoord = false;
            for (int i = 0; i <= 6; i++)
            {
                if (i == 2)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[i];
                    _excelWorkSheet.Cells[2, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 2);
                }
                else if (i == 3)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[2, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 2);
                    afterCoord = true;
                }
                else if (afterCoord)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                }
                else
                {
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[i];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                }
            }
        }

        private void segundaParteCabecalho(Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet, int column)
        {
            string[] cabecalho = { "Metro", "Lote", "Area", "Camada", "Espessura", "Observações" };

            for (int i = column; i <= 13; i++)
            {
                _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i], _excelWorkSheet.Cells[2, i]].Merge();
            }
            for (int i = 0; i < 6; i++)
            {
                _excelWorkSheet.Cells[1, (i + column)].Value = cabecalho[i];
                configuracaoCelulaCabecalho(_excelWorkSheet, (i + column), 1);
            }
        }

        private void CabecalhoSemFoto(Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet)
        {
            string[] cabecalho = { "Item", "PI", "Coord.", "Latitude", "Longitude","Rod.", "Trecho", "Camadas", "Espessura", "Observação"};
            int column = 1;
            for (int i = 1; i <= 9; i++)
            {
                if (i == 3)
                {
                    _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i], _excelWorkSheet.Cells[1, (i + 1)]].Merge();
                    i = i + 1;
                }
                else
                {
                    _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i], _excelWorkSheet.Cells[2, i]].Merge();
                }
            }

            bool afterCoord = false;
            for (int i = 0; i <= 8; i++)
            {
                if (i == 2)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[i];
                    _excelWorkSheet.Cells[2, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 2);
                }
                else if (i == 3)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[2, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 2);
                    afterCoord = true;
                }
                else if (afterCoord)
                {
                    int j = i + 1;
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[j];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                }
                else
                {
                    _excelWorkSheet.Cells[1, (column + i)].Value = cabecalho[i];
                    configuracaoCelulaCabecalho(_excelWorkSheet, (column + i), 1);
                }
            }
        }

        private void cabecalhoFoto(Microsoft.Office.Interop.Excel._Worksheet _excelWorkSheet, int columnFoto)
        {
            //EDITA CELULAS DAS FOTOS
            for (int i = 0; i < 10; i++)
            {
                _excelWorkSheet.Range[_excelWorkSheet.Cells[1, i + columnFoto], _excelWorkSheet.Cells[2, i + columnFoto]].Merge(); //FOTO

                _excelWorkSheet.Cells[1, (i + columnFoto)].Value = "Foto 0" + (i + 1); // Atribuindo valor da célula mesclada
                _excelWorkSheet.Cells[1, (i + columnFoto)].HorizontalAlignment = XlHAlign.xlHAlignCenter; // add alinhamento horizontal da célula
                _excelWorkSheet.Cells[1, (i + columnFoto)].VerticalAlignment = XlHAlign.xlHAlignCenter; // add alinhamento vertical da célula
                _excelWorkSheet.Cells[1, (i + columnFoto)].Font.Bold = true; // add a célula fonte negrito
                _excelWorkSheet.Cells[1, (i + columnFoto)].RowHeight = 20; // add altura da célula
                _excelWorkSheet.Cells[1, (i + columnFoto)].Font.Size = 12; // add tamanho da font
            }
        }

        private void connectionBDCompleto()
        {
            DAL DbConnection = new DAL(localhost);
            using (var conn = new NpgsqlConnection(DbConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                var commandCount = new NpgsqlCommand();
                var command = new NpgsqlCommand();
                string comando = comandoBDRelatorioCompleto();
                string comandoCount = comandoBDCount();

                commandCount = new NpgsqlCommand(comandoCount, conn);
                command = new NpgsqlCommand(comando, conn);

                countRows = (Int64)commandCount.ExecuteScalar();
                var reader = command.ExecuteReader();

                campoRe = new string[countRows, 13];
                int linha = 0;

                while (reader.Read())
                {
                    grid = string.Format(
                        reader.GetString(0) + ";" + //nome
                        reader.GetString(1) + ";" + //latitude
                        reader.GetString(2) + ";" + //longitude
                        reader.GetString(3) + ";" + //km
                        reader.GetString(4) + ";" + //rodovia
                        reader.GetString(5) + ";" + //trecho
                        reader.GetString(6) + ";" + //metro
                        reader.GetString(7) + ";" + //lote
                        reader.GetString(8) + ";" + //area
                        reader.GetString(9) + ";" + //observacao
                        reader.GetString(10) + ";" + //camada
                        reader.GetString(11) + ";" + //espessura
                        reader.GetString(12));       //foto

                    for (int i = 0; i < 10; i++)
                    {
                        campoRe[linha, i] = grid.Split(';')[i];
                    }
                    //string com todos os nomes da camada, espessura e foto
                    campoRe[linha, 10] = string.Format(reader.GetString(10));
                    campoRe[linha, 11] = string.Format(reader.GetString(11));
                    campoRe[linha, 12] = string.Format(reader.GetString(12));

                    linha++;
                }
                reader.Close();
                conn.Close();
            }
        }

        private void connectionBDParcial()
        {
            DAL DbConnection = new DAL(localhost);

            using (var conn = new NpgsqlConnection(DbConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                var commandCount = new NpgsqlCommand();
                var command = new NpgsqlCommand();
                string comando = comandoBDRelatorioParcial();
                string comandoCount = comandoBDCount();

                commandCount = new NpgsqlCommand(comandoCount, conn);
                command = new NpgsqlCommand(comando, conn);

                countRows = (Int64)commandCount.ExecuteScalar();
                var reader = command.ExecuteReader();

                campoRe = new string[countRows, 7];
                int linha = 0;

                while (reader.Read())
                {
                    grid = string.Format(
                        reader.GetString(0) + ";" + //nome
                        reader.GetString(1) + ";" + //latitude
                        reader.GetString(2) + ";" + //longitude
                        reader.GetString(3) + ";" + //km
                        reader.GetString(4) + ";" + //rodovia
                        reader.GetString(5) + ";" + //trecho
                        reader.GetString(6));       //foto

                    for (int i = 0; i < 6; i++)
                    {
                        campoRe[linha, i] = grid.Split(';')[i];
                    }
                    //string com todos os nomes da foto
                    campoRe[linha, 6] = string.Format(reader.GetString(6));
                    linha++;
                }
                reader.Close();
                conn.Close();
            }
        }

        private void connectionBDSemFotos()
        {
            DAL DbConnection = new DAL(localhost);

            using (var conn = new NpgsqlConnection(DbConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                var commandCount = new NpgsqlCommand();
                var command = new NpgsqlCommand();
                string comando = comandoBDRelatorioSemFotos();
                string comandoCount = comandoBDCount();

                commandCount = new NpgsqlCommand(comandoCount, conn);
                command = new NpgsqlCommand(comando, conn);

                countRows = (Int64)commandCount.ExecuteScalar();
                var reader = command.ExecuteReader();

                campoRe = new string[countRows, 9];
                int linha = 0;

                while (reader.Read())
                {
                    grid = string.Format(
                        reader.GetString(0) + ";" + //nome
                        reader.GetString(1) + ";" + //latitude
                        reader.GetString(2) + ";" + //longitude
                        reader.GetString(3) + ";" + //rodovia
                        reader.GetString(4) + ";" + //trecho
                        reader.GetString(5) + ";" + //Camadas
                        reader.GetString(6) + ";" + //espessura
                        reader.GetString(7)         //observação
                        );

                    for (int i = 0; i < 5; i++)
                    {
                        campoRe[linha, i] = grid.Split(';')[i];
                    }
                    campoRe[linha, 5] = string.Format(reader.GetString(5));
                    campoRe[linha, 6] = string.Format(reader.GetString(6));
                    campoRe[linha, 7] = grid.Split(';')[13];

                    linha++;
                }
                reader.Close();
                conn.Close();
            }
        }

    }
}

