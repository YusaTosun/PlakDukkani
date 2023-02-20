using BLL.Services;
using DAL;
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
    public partial class AlbumSayfasi : Form
    {
        PlakDukkaniContext _db=new PlakDukkaniContext();
        PlakBilgileriService _plakServis=new PlakBilgileriService();
        public AlbumSayfasi()
        {
            InitializeComponent();
        }

        private void AlbumSayfasi_Load(object sender, EventArgs e)
        {
            Temizle();
            TumunuGoster();
            btnSatisDurmus.Click += Click;
            btnSatisDevamEden.Click += Click;
            btnEnYeni10.Click += Click;
            btnIndirimliAlbum.Click += Click;
            btnTumunuGoster.Click += Click;
        }

        private void Temizle()
        {
            txtAlbumAdi.Clear();
            txtAlbumSanatciGrubu.Clear();
            txtAlbumFiyati.Clear();
            txtIndirimOrani.Clear();
            txtSatisDurumu.Clear();
        }

        private void Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            object tag = buton.Tag;
            switch(tag)
            {
                case "1": SatisDurmus(); break;
                case "2":SatisDevam(); break;
                case "3":EnYeniOn(); break;
                case "4":IndirimliAlbum(); break;
                case "5":TumunuGoster(); break;
            }
        }

        private void TumunuGoster()
        {
            dgvPlakListe.DataSource = _plakServis.TumunuGoster();
        }

        private void IndirimliAlbum()
        {
            dgvPlakListe.DataSource = _plakServis.IndirimdekiAlbumler();
            dgvPlakListe.Columns[2].Visible = false;
        }

        private void EnYeniOn()
        {
            dgvPlakListe.DataSource = _plakServis.SonOnAlbum();
            dgvPlakListe.Columns[2].Visible = false;
        }

        private void SatisDevam()
        {
            dgvPlakListe.DataSource = _plakServis.SatisiDevamEdenAlbumler();
        }

        private void SatisDurmus()
        {
            dgvPlakListe.DataSource = _plakServis.SatisiDurmusAlbumler();
        }
    }
}
