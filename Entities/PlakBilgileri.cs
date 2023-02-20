using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PlakBilgileri
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string AlbumSanatcisiGrubu { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public double AlbumFiyati { get; set; }
        public double? IndirimOrani { get; set; }
        public bool SatisDurum { get; set; }

    }
}
