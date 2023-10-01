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
using YardimMasasi.Nesneler.DuyuruNesneler.Db;
using YardimMasasi.Nesneler.GorevNesneler.Db;
using YardimMasasi.Nesneler.HaberNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;
using YardimMasasi.VeriErisim.Mappings;
using YardimMasasi.VeriErisim.Mappings.KullaniciModul;
using YardimMasasi.Nesneler.KullaniciNesneler.Db;

namespace YardimMasasi.VeriErisim
{
    public class YardimMasasiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial " +
                "Catalog=KytYardimMasasi;MultipleActiveResultSets=True;App=EntityFramework;" +
                "PersistSecurityInfo=False;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<AnaKonu> AnaKonular { get; set; }
        public DbSet<AltKonu> AltKonular { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<SurecTanimi> SurecTanimlari { get; set; }
        public DbSet<SurecAdimi> SurecAdimiTanimlari { get; set; }
        public DbSet<Surec> Surecler { get; set; }
        public DbSet<SurecAdimi> SurecAdimlari { get; set; }
        public DbSet<EkipAltKonu> EkipAltKonular { get; set; }
        public DbSet<Ekip> Ekipler { get; set; }
        public DbSet<Birim> Birimler { get; set; }

        public DbSet<Duyuru> Duyurular { get; set; }
        public DbSet<DuyuruDetay> DuyuruDetaylar { get; set; }

        public DbSet<Haber> Haberler  { get; set; }
        public DbSet<HaberBolum> HaberBolumler  { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<KullaniciRol> KullaniciRoller { get; set; }
        public DbSet<RolMenu> RolMenuler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Mappingleri buraya ekliyoruz.
            modelBuilder.ApplyConfiguration(new AnaKonuMap());
            modelBuilder.ApplyConfiguration(new AltKonuMap());

            modelBuilder.ApplyConfiguration(new EkipMap());
            modelBuilder.ApplyConfiguration(new BirimMap());

            modelBuilder.ApplyConfiguration(new GorevMap());
            modelBuilder.ApplyConfiguration(new GorevIslemMap());
            modelBuilder.ApplyConfiguration(new GorevMesajMap());

            modelBuilder.ApplyConfiguration(new SurecMap());
            modelBuilder.ApplyConfiguration(new SurecAdimiMap());
            modelBuilder.ApplyConfiguration(new SurecTanimiMap());

            modelBuilder.ApplyConfiguration(new SurecAdimiTanimiMap());

            modelBuilder.ApplyConfiguration(new DuyuruMap());
            modelBuilder.ApplyConfiguration(new DuyuruDetayMap());

            modelBuilder.ApplyConfiguration(new HaberMap());
            modelBuilder.ApplyConfiguration(new HaberBolumMap());
            modelBuilder.ApplyConfiguration(new EkipAltKonuMap());

            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new KullaniciRolMap());
            modelBuilder.ApplyConfiguration(new RolMenuMap());

            modelBuilder.SeedData();
        }
    }
}
