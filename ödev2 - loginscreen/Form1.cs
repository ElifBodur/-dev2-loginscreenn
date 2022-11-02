using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev2___loginscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ka = tboxKa.Text;
            string sifre = tboxSifre.Text;

            if (ka== "Aylin")
            {
                if (sifre== "12345")
                {
                    lblSonuç.Text = "Giriş Başarılı";
                }
                else
                {
                    lblSonuç.Text = "Şifreniz Yanlış";
                }
            }
            else
            {
                lblSonuç.Text = "Kullanıcı adınız yanlış";
            }
        }
    }
}
