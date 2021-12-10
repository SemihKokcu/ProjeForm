namespace ProjeNesneNew2
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           FormKapatma formKapatma = new FormKapatma();
            formKapatma.ShowDialog();
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            FormUcgenMi formUcgenMi = new FormUcgenMi();
            formUcgenMi.Show();
        }

        private void btnAltDizgi_Click(object sender, EventArgs e)
        {
            FormAltdizgiMi formAltdizgiMi = new FormAltdizgiMi();
            formAltdizgiMi.Show();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            FormKareMi formKareMi = new FormKareMi();
            formKareMi.Show();
        }

        private void btnTasKagýtMakas_Click(object sender, EventArgs e)
        {
            FormTasKagitMakas formTasKagitMakas = new FormTasKagitMakas();
            formTasKagitMakas.Show();
        }

        private void btnOnArtEk_Click(object sender, EventArgs e)
        {
            FormOnEkArkaEk formOnEkArkaEk = new FormOnEkArkaEk();
            formOnEkArkaEk.Show();
        }
    }
}