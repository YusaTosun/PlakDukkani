namespace PlakDukkaniUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitEkrani kayit = new();
            kayit.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SifreKarakterKontrol(txtSifre.Text);
        }

        private void SifreKarakterKontrol(string sifre)
        {

            int BuyukHarfSayisi = 0;
            int KucukHarfSayisi = 0;
            string Karakterler = "!:+*";

            foreach (char item in sifre)
            {
                if (Karakterler.Contains(item))
                {
                    Karakterler+=1; // burda kaldým
                }
            }

            MessageBox.Show(Karakterler.ToString());
            
        }
    }
}