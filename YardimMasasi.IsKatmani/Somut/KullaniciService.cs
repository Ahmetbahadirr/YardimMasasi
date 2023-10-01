using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.KullaniciNesneler.Db;
using YardimMasasi.Nesneler.KullaniciNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Somut
{
    public class KullaniciService : IKullaniciService
    {
        public KullaniciDto KullaniciGetir(int id)
        {
            using (var c = new YardimMasasiContext())
            {
                var k = c.Kullanicilar.FirstOrDefault(x => x.Id == id);

                if (k == null)
                    throw new Exception("Kullanıcı Bulunamadı");

                var roller = c.KullaniciRoller.Include(r => r.Rol).Where(r => r.KullaniciId == id).Select(r => new RolDto
                {
                    Id = r.Rol.Id,
                    RolAdi = r.Rol.RolAdi
                }).ToList();

                List<MenuDto> menu = new List<MenuDto>();

                foreach (var item in roller)
                {
                    var menuler = c.RolMenuler.Include(rm => rm.Menu).Where(rm => rm.RolId == item.Id).Distinct().Select(m => new MenuDto
                    {
                        Id = m.Menu.Id,
                        Url = m.Menu.Url,
                        HtmlClass = m.Menu.HtmlClass,
                        IconUrl = m.Menu.IconUrl
                    }).ToList();

                    item.Menuler = menuler;
                }

                //var query = (from kr in c.KullaniciRoller
                //             join r in c.Roller on kr.RolId equals r.Id
                //             join rm in c.RolMenuler on kr.RolId equals rm.RolId
                //             join m in c.Menuler on rm.MenuId equals m.Id
                //             where kr.KullaniciId == id
                //             group new { r, m } by r into g
                //             select new RolDto
                //             {
                //                 Id = g.Key.Id,
                //                 RolAdi = g.Key.RolAdi,
                //                 Menuler = g.Select(rm => new MenuDto { Id = rm.m.Id, Url = rm.m.Url, HtmlClass = rm.m.HtmlClass, IconUrl = rm.m.IconUrl }).ToList()
                //             });

                return new KullaniciDto
                {
                    Id = k.Id,
                    Adi = k.Adi,
                    Soyadi = k.Soyadi,
                    Eposta = k.Eposta,
                    Roller = roller
                };
            }
        }
    }
}
