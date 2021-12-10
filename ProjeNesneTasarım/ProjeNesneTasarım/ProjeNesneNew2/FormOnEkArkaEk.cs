using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeNesneNew2
{
    public partial class FormOnEkArkaEk : Form
    {
        public FormOnEkArkaEk()
        {
            InitializeComponent();
        }

        private void btnOnArkaEk_Click(object sender, EventArgs e)
        {
            string omMuArkaMi = tboxDizgi1.Text;
            string dizgi = tBoxDizgi2.Text; 

            int Uzunluk = omMuArkaMi.Length;

            string kontrolOn = dizgi.Substring(0, Uzunluk);
           
            string kontrolArka = dizgi.Substring(dizgi.Length-Uzunluk,Uzunluk);


            if (omMuArkaMi == kontrolOn)
            {
                string s = "On Takı";
                lblSonuc.Text = s;
            }
            else if (omMuArkaMi == kontrolArka)
            {
                string s1 = "Arka takı";
                lblSonuc.Text = s1;
            }
            else
            {
                string s3 = "Hiçbiri değil";
                lblSonuc.Text = s3;
            }


        }
    }
}
