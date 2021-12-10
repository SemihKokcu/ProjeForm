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
    public partial class FormTasKagitMakas : Form
    {
        public FormTasKagitMakas()
        {
            InitializeComponent();
        }

        private void FormTasKagitMakas_Load(object sender, EventArgs e)
        {
            comBoxSecim1.SelectedIndex = 0;
            comBoxSecim2.SelectedIndex = 0;
        }

        private void btnKazanan_Click(object sender, EventArgs e)
        {
            // kazanma durumları
            if ((comBoxSecim1.SelectedIndex == 1 && comBoxSecim2.SelectedIndex == 3) ||
                (comBoxSecim1.SelectedIndex == 2 && comBoxSecim2.SelectedIndex == 1) ||
                (comBoxSecim1.SelectedIndex == 3 && comBoxSecim2.SelectedIndex == 2))
            {
                string s = "1.Kazandı";
                lblSonuc.Text = s;
            }
            else if ((comBoxSecim1.SelectedIndex == 1 && comBoxSecim2.SelectedIndex == 1) ||
                (comBoxSecim1.SelectedIndex == 2 && comBoxSecim2.SelectedIndex == 2) ||
                (comBoxSecim1.SelectedIndex == 3 && comBoxSecim2.SelectedIndex == 3))
            {
                string s1 = "Berabere";
                lblSonuc.Text = s1;
            }
            else if ((comBoxSecim1.SelectedIndex == 1 && comBoxSecim2.SelectedIndex == 2) ||
                (comBoxSecim1.SelectedIndex == 2 && comBoxSecim2.SelectedIndex == 3) ||
                (comBoxSecim1.SelectedIndex == 3 && comBoxSecim2.SelectedIndex == 1))
            {
                string s3 = "1.Kaybetti";
                lblSonuc.Text = s3;
            }
        }
    }
}
