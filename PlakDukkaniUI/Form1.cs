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
            if (SifreKontrol(txtSifre.Text) && KullaniciAdiKontrol(txtKullaniciAdi.Text))
            {
                AlbumSayfasi albumSayfasi = new AlbumSayfasi();
                albumSayfasi.Show();
                this.Hide();
            }

        }
        
        /// <summary>
        /// Kullan�c� ad�n� kontrol eden method
        /// </summary>
        /// <returns>Kullan�c� ad� mevcutsa Tru,de�ilse False d�ner</returns>
        private bool KullaniciAdiKontrol(string _KullaniciAdi)
        {
            using (_db=new())
            {
                if (_db.User.Any(x => x.KullaniciAdi.Contains(_KullaniciAdi)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           


        }
        /// <summary>
        /// Kullan�c� ad�n�n daha �nce var olup olmad���n� kontrol
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns>kullan�c� ad� database yoksa True,varsa False</returns>
        private bool SifreKontrol(string sifre)
        {
            using (_db=new())
            {
                if (_db.User.Any(x => x.Sifre.Contains(sifre)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }
    }
}