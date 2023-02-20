using DAL;

namespace PlakDukkaniUI
{
    public partial class Form1 : Form
    {
        PlakDukkaniContext _db;
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
            if (true)
            {

            }
            SifreKarakterKontrol(txtSifre.Text);
        }
        /// <summary>
        /// þifrenin uygunluðunu kontrol eden method
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns>Þifre uygunsa True,deðilse false döner</returns>
        private bool SifreKarakterKontrol(string sifre)
        {

            int BuyukHarfSayisi = 0;
            int kucukHarfSayisi = 0;
            string Karakterler = "!:+*";
            int karakterSayisi = 0;

            foreach (char item in sifre)
            {
                if (Karakterler.Contains(item))
                {
                    karakterSayisi += 1; // burda kaldým
                }

                else if (char.IsLetter(item))
                {

                    if (!char.IsLower(item))
                    {
                        BuyukHarfSayisi++;
                    }
                    else
                    {
                        kucukHarfSayisi++;
                    }
                }

            }


            if (sifre.Length >= 8 && BuyukHarfSayisi >= 2 && kucukHarfSayisi>=3 && karakterSayisi>=2)
            {
                return true;
            }
            else
            {
                return false;
            }

           

        }
        private void KullaniciAdiKontrol()
        {
            using (_db=new())
            {
                
            }
        }
    }
}