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
        PlakBilgileri _bilgi=new PlakBilgileri();
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
                var IndirimOrani = _db.PlakBilgileri.Where(x => x.IndirimOrani != 0).Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciGrup = x.AlbumSanatcisiGrubu,
                    IndirimOrani = x.IndirimOrani
                }).OrderByDescending(x => x.IndirimOrani).ToList();
                return IndirimOrani;
            }
        }
        public dynamic TumunuGoster()
        {
            using (_db = new PlakDukkaniContext())
            {
                var tumunuGoster= _db.PlakBilgileri.Select(x=> new
                {
                    AlbumAdi= x.AlbumAdi,
                    SanatciGrup = x.AlbumSanatcisiGrubu,
                    CikisTarihi=x.AlbumCikisTarihi
                }).OrderBy(x=>x.CikisTarihi).ToList();
                return tumunuGoster;
            }
        }
        public void KayitEkle(string Ad,string Sanatci,DateTime tarih,double fiyat,double oran,bool durum)
        {
            _bilgi.AlbumAdi = Ad;
            _bilgi.AlbumSanatcisiGrubu= Sanatci;
            _bilgi.AlbumCikisTarihi= tarih;
            _bilgi.AlbumFiyati=fiyat;
            _bilgi.IndirimOrani = oran;
            _bilgi.SatisDurum= durum;
            _db.PlakBilgileri.Add(_bilgi);
        }
    }
}
