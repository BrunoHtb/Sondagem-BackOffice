using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgFormularioEngenharia2.sondagem
{
    public partial class Frm_Fotos : Form
    {
        public Bitmap img;
        public bool closed = false;
        ~Frm_Fotos() { }

        public Frm_Fotos()
        {
            InitializeComponent();
        }

        private void pct_boxMaior_Click(object sender, EventArgs e) { }

        public void pct_boxMaior_Exibir(Bitmap bm)
        {
            pct_boxMaior.Image = bm;
            this.img = bm;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {

            var wfactor = (double)img.Width / pct_boxMaior.ClientSize.Width;
            var hfactor = (double)img.Height / pct_boxMaior.ClientSize.Height;
            var resizeFactor = Math.Max(wfactor, hfactor);
            var imageSize = new Size((int)(img.Width / resizeFactor), (int)(img.Height / resizeFactor));

            Console.WriteLine("Image Size: " + imageSize + "    WIDTH Size: " + imageSize.Width + "    HEIGHT Size: " + imageSize.Height);

            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (pct_boxMaior.Width < 50)
                        // lbl_Zoom.Text = pictureBox1.Image.Size; 
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (pct_boxMaior.Width > 2000)
                        return;
                }

                pct_boxMaior.Width += Convert.ToInt32(imageSize.Width * e.Delta / 2000);
                pct_boxMaior.Height += Convert.ToInt32(imageSize.Height * e.Delta / 2000);
            }
        }

        private void Frm_Fotos_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.closed = true;
        }
    }
}
