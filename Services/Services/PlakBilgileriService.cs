using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{ 
    public class PlakBilgileriService
    {
        PlakDukkaniContext _db=new PlakDukkaniContext();
        public dynamic SatisiDurmusAlbumler()
        {
            using(_db= new PlakDukkaniContext())
            {

               var satisiDurmusAlbum = _db.PlakBilgileri.Where(x => x.SatisDurum == false).Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciGrup = x.AlbumSanatcisiGrubu
                }).ToList();
                return satisiDurmusAlbum;
            }
        }
        public dynamic SatisiDevamEdenAlbumler()
        {
            using (_db = new PlakDukkaniContext())
            {
                var satisiDevamEdenAlbumler = _db.PlakBilgileri.Where(x => x.SatisDurum == true).Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciGrup = x.AlbumSanatcisiGrubu
                }).ToList();
                return satisiDevamEdenAlbumler;
            }
        }
        public dynamic SonOnAlbum()
        {
            using (_db = new PlakDukkaniContext())
            {
               var sonOnAlbum = _db.PlakBilgileri.Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciGrup = x.AlbumSanatcisiGrubu,
                    PlakId = x.Id
                }).OrderByDescending(x => x.PlakId).Take(10).ToList();
                return sonOnAlbum;
            }
        }
        public dynamic IndirimdekiAlbumler()
        {
            using (_db = new PlakDukkaniContext())
            {
                _db.PlakBilgileri.

            }
        }
    }
}
