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
        public AlbumSayfasi()
        {
            InitializeComponent();
        }

        private void AlbumSayfasi_Load(object sender, EventArgs e)
        {
            btnSatisDurmus.Click += Click;
            btnSatisDevamEden.Click += Click;
            btnEnYeni10.Click += Click;
            btnIndirimliAlbum.Click += Click;
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
            }
        }

        private void IndirimliAlbum()
        {
            
        }

        private void EnYeniOn()
        {
        }

        private void SatisDevam()
        {
        }

        private void SatisDurmus()
        {
            
        }
    }
}
