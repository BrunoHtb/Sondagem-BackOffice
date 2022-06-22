using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFormularioEngenharia2.sondagemClasses
{
    class RelatorioWord
    {
        private string pathRelatorio;
        private string pathSavePhoto;
        public RelatorioWord(string pathRelatorio, string pathSavePhoto)
        {
            this.pathRelatorio = pathRelatorio;
            this.pathSavePhoto = pathSavePhoto;
        }

        public void geraRelatorioWord(string caminhoWordSalva, string lote, string poco, string rodovia, string trecho, string longitude, string latitude, string nomeFoto, string regional, string camada1, string camada2, string camada3, string camada4, string espessura1, string espessura2, string espessura3, string espessura4, string Km)
        {
            object missing = System.Reflection.Missing.Value;
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;
            var wordDoc = wordApp.Documents.Open(caminhoWordSalva + "PRODUTO.docx", ReadOnly: false);
            if (lote == "Lote 01")
            {
                //CAMINHO QUE ESTÁ O MODLEO DO WORD
                wordDoc = wordApp.Documents.Open(caminhoWordSalva + "PRODUTO.docx", ReadOnly: false);
            }
            else
            {
                //CAMINHO QUE ESTÁ O MODLEO DO WORD
                wordDoc = wordApp.Documents.Open(caminhoWordSalva + "PRODUTO_1.docx", ReadOnly: false);
            }

            ImportarFotos img = new ImportarFotos(pathSavePhoto);
            List<string> nomeFotos = img.viewFoto(nomeFoto);
           
            if (nomeFotos[0] != null)
            {
                wordApp.Selection.Find.Execute("Imagem1");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                if (range.Text.Contains("Imagem1"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[0], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[1] != null)
            {
                wordApp.Selection.Find.Execute("Imagem2");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem2"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[1], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();                    
                }
            }
            if (nomeFotos[2] != null)
            {
                wordApp.Selection.Find.Execute("Imagem3");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem3"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[2], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[3] != null)
            {
                wordApp.Selection.Find.Execute("Imagem4");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem4"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[3], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[4] != null)
            {
                wordApp.Selection.Find.Execute("Imagem5");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem5"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[4], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[7] != null)
            {
                wordApp.Selection.Find.Execute("Imagem6");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem6"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[7], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[6] != null)
            {
                wordApp.Selection.Find.Execute("Imagem7");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem7"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[6], missing, missing, temprange);
                    shape.Width = 170;
                    shape.Height = 150;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }
            if (nomeFotos[5] != null)
            {
                wordApp.Selection.Find.Execute("Imagem8");
                Microsoft.Office.Interop.Word.Range range = wordApp.Selection.Range;
                Microsoft.Office.Interop.Word.Range temprange;
                range = wordApp.Selection.Range;
                if (range.Text.Contains("Imagem8"))
                {
                    temprange = wordDoc.Range(range.End, range.End + 1);
                    temprange.Select();
                    var shape = wordDoc.InlineShapes.AddPicture(nomeFotos[5], missing, missing, temprange);    //Tabela
                    shape.Width = 450;
                    shape.Height = 450;
                    temprange.SetRange(0, 0);
                    temprange.Select();
                }
            }

            Microsoft.Office.Interop.Word.Find fnd = wordApp.ActiveWindow.Selection.Find;

            fnd.Text = "Imagem1";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem2";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem3";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem4";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem5";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem6";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem7";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            fnd.Text = "Imagem8";
            fnd.Replacement.Text = "";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "cel_Lote";
            fnd.Replacement.Text = lote;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Poco";
            fnd.Replacement.Text = poco;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Rodovia";
            fnd.Replacement.Text = rodovia;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Trecho";
            fnd.Replacement.Text = trecho;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Km";
            fnd.Replacement.Text = Km;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Longitude";
            fnd.Replacement.Text = longitude;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Latitude";
            fnd.Replacement.Text = latitude;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            if(regional != "null")
            {
                fnd.Text = "cel_Regional";
                fnd.Replacement.Text = regional;
                fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            }

            fnd.Text = "cel_Camada1";
            fnd.Replacement.Text = camada1;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Camada2";
            fnd.Replacement.Text = camada2;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Camada3";
            fnd.Replacement.Text = camada3;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Camada4";
            fnd.Replacement.Text = camada4;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Espessura1";
            fnd.Replacement.Text = espessura1;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Espessura2";
            fnd.Replacement.Text = espessura2;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Espessura3";
            fnd.Replacement.Text = espessura3;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "cel_Espessura4";
            fnd.Replacement.Text = espessura4;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            //Local que vai ser salvo e a extensão
            wordDoc.SaveAs(pathRelatorio + poco + ".docx");
            wordApp.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            wordApp.Quit();
            
        }

    }
}
