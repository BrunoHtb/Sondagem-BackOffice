using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgFormularioEngenharia2
{
    public partial class Frm_loading : Form
    {
        public bool firstTime = true;
        public int count = 0;
        
        public Frm_loading()
        {
            InitializeComponent();
        }


        public void maxCount_load(int maximumCount)
        {
            this.firstTime = false;
            this.prgB_loading.Maximum = maximumCount;
            lbl_contadorMaximo.Text = maximumCount.ToString();
        }

        public void loading()
        {
            this.prgB_loading.Value += 1;

            lbl_contador.Text =  this.prgB_loading.Value.ToString(); 
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.firstTime = true;
            this.prgB_loading.Value = 0;
            this.btn_ok.Enabled = false;
            this.Hide();
        }

    }
}
