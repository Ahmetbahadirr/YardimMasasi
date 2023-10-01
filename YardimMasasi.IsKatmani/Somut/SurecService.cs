using Microsoft.EntityFrameworkCore;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.GorevNesneler.Db;
using YardimMasasi.Nesneler.GorevNesneler.Dto;
using YardimMasasi.Nesneler.SurecNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Somut
{
    public class SurecService : ISurecService
    {
        public List<SurecTanimiListItemDto> GetSurecTanimlari()
        {
            using (var c = new YardimMasasiContext())
            {
                var list = c.SurecTanimlari.Select(x => new SurecTanimiListItemDto
                {
                    Id = x.Id,
                    Adi = x.Adi
                }).ToList();

                list.ForEach(x =>
                {
                    x.AdimSayisi = c.SurecAdimiTanimlari.Count(a => a.SurecId == x.Id);
                });

                return list;
            }
        }

        public void SurecBaslat(GorevCreateDto gorev)
        {
            using (var c = new YardimMasasiContext())
            {
                //1. Gelen Alt Konu mevcut mu?
                if (!c.AltKonular.Any(x => x.Id == gorev.AltKonuId))
                    throw new Exception("Bu alt konu bulunamadı");

                //2. Alt Konu ile ilişkili bir süreç tanımı mevcut mu?
                var altKonu = c.AltKonular.First(a => a.Id == gorev.AltKonuId);

                if (altKonu.SurecTanimiId == null)
                    throw new Exception("Alt konu için süreç tanımlanmamıştır.");

                var surecTanimId = altKonu.SurecTanimiId;

                var surecTanimi = c.SurecTanimlari.Include(x => x.SurecAdimlari).FirstOrDefault(x => x.Id == surecTanimId);

                if (surecTanimi == null || surecTanimi.SurecAdimlari.Count == 0)
                    throw new Exception("Alt konu ile ilişkili bir süreç tanımı bulunamadı");

                //3. Süreç adımları elde edilir.
                var adimlar = new List<SurecAdimi>();

                var olusturmaTarihi = DateTime.Now;

                foreach (var adim in surecTanimi.SurecAdimlari)
                {
                    var ekipler = (from ea in c.EkipAltKonular
                                   join e in c.Ekipler on ea.EkipId equals e.Id
                                   where ea.AltKonuId == gorev.AltKonuId && e.BirimId == adim.BirimId
                                   select e).ToList();

                    if (ekipler != null && ekipler.Count > 0)
                    {
                        adimlar.Add(new SurecAdimi
                        {
                            BirimId = adim.BirimId,
                            Sira = adim.Sira
                        });
                    }
                }

                //4. Mevcut süreç tanımında elde edilecek olan birimlerde en az 1 ekip olmalı
                if (adimlar.Count == 0)
                    throw new Exception("Süreç oluşturulamadı.");

                adimlar = adimlar.OrderBy(a => a.Sira).ToList();

                for (int i = 1; i <= adimlar.Count; i++)
                {
                    adimlar[i - 1].Sira = i;
                }

                using (var t = c.Database.BeginTransaction())
                {
                    try
                    {
                        //5. Görev kaydedilir
                        var g = new Gorev();
                        g.OluşturulmaTarihi = olusturmaTarihi;
                        g.TalepSahibiId = 1; //TODO: GörecSahibiId ekenecek. Bu bilgi kullanıcıdan gelecek.
                        g.BirimId = adimlar.First(x => x.Sira == 1).BirimId;
                        g.AltKonuId = gorev.AltKonuId;
                        g.TeknisyenId = 0;

                        c.Add(g);
                        c.SaveChanges();

                        //5. Süreç oluşturulur.
                        var surec = new Surec();
                        adimlar.ForEach(a => { a.SurecId = g.Id; });
                        adimlar.First(x => x.Sira == 1).AktifAdim = true;
                        surec.SurecAdimlari = adimlar;
                        surec.SurecTanimiId = (int)surecTanimId;
                        surec.Id = g.Id;
                        c.Add(surec);
                        c.SaveChanges();

                        t.Commit();
                    }
                    catch (Exception)
                    {
                        t.Rollback();
                    }
                }
            }
        }
    }
}
