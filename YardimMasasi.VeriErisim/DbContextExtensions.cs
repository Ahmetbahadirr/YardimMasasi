using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AltKonuNesneler.Db;
using YardimMasasi.Nesneler.AnaKonuNesneler.Db;
using YardimMasasi.Nesneler.BirimNesneler.Db;
using YardimMasasi.Nesneler.EkipNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim
{
    public static class DbContextExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region AnaKonu

            var anaKonular = new List<AnaKonu>
            {
                new AnaKonu
                {
                    Id=1,
                    Tanim = "Donanım Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new AnaKonu
                {
                    Id=2,
                    Tanim = "Sistem Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new AnaKonu
                {
                    Id=3,
                    Tanim = "Erişim Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new AnaKonu
                {
                    Id=4,
                    Tanim = "Tanımlama Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new AnaKonu
                {
                    Id=5,
                    Tanim = "E-posta Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new AnaKonu
                {
                    Id=6,
                    Tanim = "Şifre Sorunları",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                }
            };

            modelBuilder.Entity<AnaKonu>().HasData(anaKonular.ToArray());

            #endregion

            #region AltKonu

            var altKonular = new List<AltKonu>
            {
                new AltKonu
                {
                    Id = 1,
                    AnaKonuId =1,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ekran Çalışmıyor"
                },
                new AltKonu
                {
                    Id = 2,
                    AnaKonuId =1,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Bilgisayarım Açılmıyor"
                },
                new AltKonu
                {
                    Id = 3,
                    AnaKonuId =1,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Klavye/Mouse Çalışmıyor"
                },
                new AltKonu
                {
                    Id = 4,
                    AnaKonuId =2,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Sistem Genel Sorun"
                },
                new AltKonu
                {
                    Id = 5,
                    AnaKonuId =2,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ebys Açılmıyor"
                },
                new AltKonu
                {
                    Id = 6,
                    AnaKonuId =2,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "E-İmza çalışmıyor"
                },
                new AltKonu
                {
                    Id = 7,
                    AnaKonuId =3,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ebys sistemi erişemiyorum"
                },
                new AltKonu
                {
                    Id = 8,
                    AnaKonuId =3,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ortak klasöre erişemiyorum"
                },
                new AltKonu
                {
                    Id = 9,
                    AnaKonuId =3,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ağ bağlantı hatası"
                },
                new AltKonu
                {
                    Id = 10,
                    AnaKonuId =4,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Profil tanımlama"
                },
                new AltKonu
                {
                    Id = 11,
                    AnaKonuId =4,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Ebys tanımlama"
                },
                new AltKonu
                {
                    Id = 12,
                    AnaKonuId =4,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Kullanıcı tanımlama"
                },
                new AltKonu
                {
                    Id = 13,
                    AnaKonuId =5,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "E-posta açılmıyor"
                },
                new AltKonu
                {
                    Id = 14,
                    AnaKonuId =5,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Kota artırımı"
                },
                new AltKonu
                {
                    Id = 15,
                    AnaKonuId =5,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Arşivleme Sorunu"
                },
                new AltKonu
                {
                    Id = 16,
                    AnaKonuId =6,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Portal şifre sorunu"
                },
                new AltKonu
                {
                    Id = 17,
                    AnaKonuId =6,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Şifre güncelleme sorunu"
                },
                new AltKonu
                {
                    Id = 18,
                    AnaKonuId =6,
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now,
                    Tanim = "Domain şifresi sorunu"
                }
            };

            modelBuilder.Entity<AltKonu>().HasData(altKonular.ToArray());

            #endregion

            #region Birim

            var birimler = new List<Birim>
            {
                new Birim
                {
                    Id=1,
                    Adi = "Yazılım ve Uygulama Müdürlüğü",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Birim
                {
                    Id=2,
                    Adi = "Donanım Müdürlüğü",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Birim
                {
                    Id=3,
                    Adi = "Network Müdürlüğü",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Birim
                {
                    Id=4,
                    Adi = "Sistem Müdürlüğü",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                }
            };

            modelBuilder.Entity<Birim>().HasData(birimler.ToArray());

            #endregion

            #region Ekipler

            var ekipler = new List<Ekip>
            {
                new Ekip
                {
                    Id=1,
                    BirimId=1,
                    Adi = "Ebys/E-imza Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=2,
                    BirimId=1,
                    Adi = "Portal Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=3,
                    BirimId=2,
                    Adi = "Bilgisayar Donanımları Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=4,
                    BirimId=2,
                    Adi = "Network Donanımları Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=5,
                    BirimId=3,
                    Adi = "Network Güvenlik Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=6,
                    BirimId=3,
                    Adi = "Network Erişim Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=7,
                    BirimId=4,
                    Adi = "Sunucu Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                },
                new Ekip
                {
                    Id=8,
                    BirimId=4,
                    Adi = "Veri Tabanı Ekibi",
                    Silindi=false,
                    OlusturmaTarihi=DateTime.Now
                }
            };

            modelBuilder.Entity<Ekip>().HasData(ekipler.ToArray());

            #endregion

            #region Ekip Alt Konu

            var ekipAltKonular = new List<EkipAltKonu>
            {
                new EkipAltKonu
                {
                    EkipId = 3,
                    AltKonuId = 1
                },
                new EkipAltKonu
                {
                    EkipId = 3,
                    AltKonuId = 2
                },
                new EkipAltKonu
                {
                    EkipId = 3,
                    AltKonuId = 3
                },
                new EkipAltKonu
                {
                    EkipId = 1,
                    AltKonuId = 6
                },
                new EkipAltKonu
                {
                    EkipId = 1,
                    AltKonuId = 5
                },
                new EkipAltKonu
                {
                    EkipId = 1,
                    AltKonuId = 7
                },
                new EkipAltKonu
                {
                    EkipId = 1,
                    AltKonuId = 11
                }
            };

            modelBuilder.Entity<EkipAltKonu>().HasData(ekipAltKonular.ToArray());

            #endregion
        }
    }
}
