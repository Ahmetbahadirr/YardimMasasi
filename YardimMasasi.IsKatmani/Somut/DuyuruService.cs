using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AnaKonuNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Db;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.VeriErisim;
using System.Data;

namespace YardimMasasi.IsKatmani.Somut
{
    public class DuyuruService : IDuyuruService
    {
        public void DuyuruEkle(DuyuruEkleDto duyuru)
        {
            using (var c = new YardimMasasiContext())
            {
                c.Add(new Duyuru
                {
                    Metin = duyuru.Konu,
                    BaslangicTarihi = duyuru.BaslangicTarihi,
                    BitisTarihi = duyuru.BitisTarihi,
                    Baslik = duyuru.Baslik

                });
                c.SaveChanges();

            }
        }

        public DuyuruDto DuyuruGuncelle(int id, DuyuruDto duyuru)
        {
            using (var c = new YardimMasasiContext())
            {
                var d = c.Duyurular.FirstOrDefault(x => x.Id == id);

                d.Metin = duyuru.Konu;
                d.BaslangicTarihi = duyuru.BaslangicTarihi;
                d.BitisTarihi = duyuru.BitisTarihi;
                d.Baslik = duyuru.Baslik;
                c.Update(d);
                c.SaveChanges();
                duyuru.Id = id;

                return duyuru;

            }
        }

        public DuyuruGuncelleDto GetirDuyuruGuncelle(int id)
        {
            using (var e = new YardimMasasiContext())
            {
                var dyr = e.Duyurular.FirstOrDefault(x => x.Id == id);

                return new DuyuruGuncelleDto
                {
                    Id = dyr.Id,
                    Konu = dyr.Metin,
                    Baslik = dyr.Baslik,
                    BaslangicTarihi = dyr.BaslangicTarihi,
                    BitisTarihi = dyr.BitisTarihi

                };

            }
        }

        public List<DuyuruListeElemaniDto> GetirDuyuruListe()
        {
            using (var c = new YardimMasasiContext())
            {
                var liste = c.Duyurular.Select(a => new DuyuruListeElemaniDto
                {
                    Id = a.Id,
                    Baslik = a.Baslik,
                    Konu = a.Metin,
                    BaslangicTarihi = a.BaslangicTarihi,
                    BitisTarihi = a.BitisTarihi
                });
                return liste.ToList();
            }
        }








    }
}
