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
using Microsoft.VisualBasic;
using Npgsql;

namespace ProgFormularioEngenharia2
{
    public partial class Login : Form
    {
        string localhost;

        public Login()
        {
            InitializeComponent();

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
                                    Console.WriteLine("linha 1 : " + s);
                                    break;  
                            }
                            _index++;
                        }
                    }
                }
            }
            catch{}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL DBLogin = new DAL(localhost);
            bool permission = DBLogin.authenticLogin(textLogin.Text, textSenha.Text);

            if(permission == true)
            {
                Frm_Principal principal = new Frm_Principal(this);
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  
            if (chkBox.Checked) 
            {
                textSenha.PasswordChar = default;
            }
            else
            {
                textSenha.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e){}
    }
}