namespace ProjeNesneNew2
{
    public partial class FormUcgenMi : Form
    {
        public FormUcgenMi()
        {
            InitializeComponent();
        }
       
        private void btnUcgenMi_Click(object sender, EventArgs e)
        {
            if (tboxTamSayi1.Text=="" || tBoxTamsayi2.Text==""
                ||tBoxTamSayi3.Text=="")
            {
                MessageBox.Show("Lütfen sayıları eksiksiz giriniz");
                
            }
            else
            {
                // girilen sayıları int veriye dönüştürdük
                int a = Convert.ToInt32(tboxTamSayi1.Text);
                int b = Convert.ToInt32(tBoxTamsayi2.Text);
                int c = Convert.ToInt32(tBoxTamSayi3.Text);

                // girilen sayıların 0 dan küçük ya da sıfır ise hatalı olduğunu gösterdik
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    string error = "Lütfen pozitif bir tam sayı giriniz.";
                    lblSonuc.Text = error;
                }
                else
                {
                    // sonuç stringlerimizi yazdık
                    string s = a + "-" + b + "-" + c + ": Bir üçgendir\n ÜÇGEN";
                    string s1 = a + "-" + b + "-" + c + ": Bir üçgen değilidir \n ÜÇGEN DEĞİL";

                    // üçgen olma koşulunu belirttik
                    if (a + b > c && a + c > b && b + c > a)
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
        private void tboxTamSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           textController.textController(sender, e);
        }

        private void tBoxTamsayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            textController.textController(sender, e);
        }

        private void tBoxTamSayi3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           textController.textController(sender, e);
        }

       
    }
}
