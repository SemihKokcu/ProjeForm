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
    public partial class FormKareMi : Form
    {
        public FormKareMi()
        {
            InitializeComponent();
        }

        private void btnUcgenMi_Click(object sender, EventArgs e)
        {
            // textBox lar boş geçilmiş mi kontrol ettik
            if (tboxKenar.Text == "" || tBoxAlan.Text == "")
            {
                MessageBox.Show("Lütfen sayıları eksiksiz giriniz");

            }
            else
            {
                int a = Convert.ToInt32(tboxKenar.Text);
                int b = Convert.ToInt32(tBoxAlan.Text);

                if (a <= 0 || b <= 0)
                {
                    string error = "Lütfen pozitif bir tam sayı giriniz.";
                    lblSonuc.Text = error;
                }
                else
                {
                    string s = b + "-" + a + "'nın karesidir \n KAREDİR";
                    string s1 = b + "-" + a + "'nın karesi değildir\n KARE DEĞİLDİR";

                    if (a * a == b)
                    {
                        lblSonuc.Text = s;
                    }
                    else
                    {
                        lblSonuc.Text = s1;
                    }
                }
            
            }

        }

        // TextController.cs içerisinde yazmış olduğumuz kontrol dosyasını yarattık
        TextController textController = new TextController();

        // KeyPress : tuşa basıldığı andaki kontroller
        private void tboxKenar_KeyPress(object sender, KeyPressEventArgs e)
        {
            textController.textController(sender, e);   
        }

        private void tBoxAlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            textController.textController(sender, e);
        }
    }
}
