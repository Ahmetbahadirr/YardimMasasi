using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;
using YardimMasasi.Nesneler.HaberNesneler.Db;
using YardimMasasi.Nesneler.HaberNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Somut
{
    public class HaberService : IHaberService
    {
        public void HaberEkle(HaberEkleDto haber)
        {
            using (var c = new YardimMasasiContext())
            {
                using (var t = c.Database.BeginTransaction())
                {
                    var h = new Haber
                    {
                        Baslik = haber.Baslik,
                        Icerik = haber.Icerik,
                        YayinTarihi = haber.YayinTarihi
                    };

                    c.Haberler.Add(h);

                    c.SaveChanges(); //Geçici kaydettik ancak Id alanını sıradaki değeri aldı.

                    var bolumler = haber.Bolumler.Select(b => new HaberBolum
                    {
                        HaberId = h.Id,
                        Baslik = b.Baslik,
                        Icerik = b.Icerik,
                        Resim = b.Resim
                    });

                    c.HaberBolumler.AddRange(bolumler);

                    c.SaveChanges(); //Geçici kaydeder transacton açtığımız için.

                    t.Commit(); //Kalıcı kayıt.
                }
            }
        }

        public HaberGuncelleDto HaberGuncelle(int id, HaberGuncelleDto haber)
        {
            using (var c = new YardimMasasiContext())
            {
                var h = c.Haberler.FirstOrDefault(x => x.Id == id);

                h.Baslik = haber.Baslik;
                h.YayinTarihi = haber.YayinTarihi;
                h.Icerik = haber.Icerik;

                c.Update(h);

                c.SaveChanges();

                return haber;
            }
        }

        public List<HaberListeElemaniDto> GetirHaberListe()
        {
            using (var c = new YardimMasasiContext())
            {
                var list = c.Haberler.Select(x => new HaberListeElemaniDto
                {
                    Id = x.Id,
                    Baslik = x.Baslik,
                    Icerik = x.Icerik,
                    YayinTarihi = x.YayinTarihi
                });
                return list.ToList();
            }
        }
        public void HaberBolumEkle(HaberBolumEkleDto haberBolum)
        {
            throw new NotImplementedException();
        }

        public HaberBolumGuncelleDto HaberBolumGuncelle(int id, HaberBolumGuncelleDto haberBolum)
        {
            throw new NotImplementedException();
        }
        public List<HaberBolumListeElemaniDto> GetirHaberBolumListe()
        {
            using (var c = new YardimMasasiContext())
            {
                var list = c.HaberBolumler.Select(x => new HaberBolumListeElemaniDto
                {
                    Id = x.Id,
                    Baslik = x.Baslik,
                    Icerik = x.Icerik,
                    Resim = x.Resim
                });
                return list.ToList();
            }
        }

        public HaberGuncelleDto HaberGetir(int id)
        {
            using (var c = new YardimMasasiContext())
            {
                var hb = c.Haberler.FirstOrDefault(x => x.Id == id);


                return new HaberGuncelleDto
                {
                    Id = hb.Id,
                    Baslik = hb.Baslik,
                    Icerik = hb.Icerik,
                    YayinTarihi = hb.YayinTarihi
                };
            }
        }
    }
}
