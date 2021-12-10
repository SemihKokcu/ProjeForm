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
    public partial class FormAltdizgiMi : Form
    {
        public FormAltdizgiMi()
        {
            InitializeComponent();
        }

        private void btnaltdizgiMi_Click(object sender, EventArgs e)
        {
            string aldDizgi = tboxDizgi1.Text;
            string dizgi = tBoxDizgi2.Text;

            bool sonuc = dizgi.Contains(aldDizgi);
           if (sonuc)
            {
                string s = "1.dizgi 2.dizginin altdizgisidir.";
                lblSonuc.Text = s;
            }
            else
            {
                string s1 = "1.dizgi 2.dizginin altdizgisi değildir.";
                lblSonuc.Text = s1;
            }


        }
    }
}
