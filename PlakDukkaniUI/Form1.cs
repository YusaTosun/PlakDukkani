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
        /// Kullanýcý adýný kontrol eden method
        /// </summary>
        /// <returns>Kullanýcý adý mevcutsa Tru,deðilse False döner</returns>
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
        /// Kullanýcý adýnýn daha önce var olup olmadýðýný kontrol
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns>kullanýcý adý database yoksa True,varsa False</returns>
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