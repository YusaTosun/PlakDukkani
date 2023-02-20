using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniUI
{
    public partial class KayitEkrani : Form
    {


        PlakDukkaniContext _db;
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (SifreKarakterKontrol(txtSifre.Text) && (txtSifre.Text==txtSifreOnay.Text) && KullanıcıAdıKontrol(txtKullaniciAdi.Text))
            {
                using (_db=new())
                {
                    _db.User.Add(new User
                    {
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,



                    });

                    _db.SaveChanges();
                }
                
               
            }
        }

        /// <summary>
        /// şifrenin uygunluğunu kontrol eden method
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns>Şifre uygunsa True,değilse false döner</returns>
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
                    karakterSayisi += 1; // burda kaldım
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


            if (sifre.Length >= 8 && BuyukHarfSayisi >= 2 && kucukHarfSayisi >= 3 && karakterSayisi >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        /// <summary>
        /// Kullanıcı adının uygunluğunu olmadığını kontrol
        /// </summary>
        /// <param name="KullaniciAdi"></param>
        /// <returns>Kullanıcı adı uygunsa True,değilse False değeri döndürür</returns>
        private bool KullanıcıAdıKontrol(string KullaniciAdi)
        {
            using (_db=new())
            {
                if (!_db.User.Any(x=>x.KullaniciAdi.Contains(KullaniciAdi)))
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
