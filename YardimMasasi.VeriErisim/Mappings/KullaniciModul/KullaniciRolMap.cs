using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YardimMasasi.Nesneler.KullaniciNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings.KullaniciModul
{
    public class KullaniciRolMap : IEntityTypeConfiguration<KullaniciRol>
    {
        public void Configure(EntityTypeBuilder<KullaniciRol> builder)
        {
            builder.HasKey(x => new { x.KullaniciId, x.RolId });
            builder.HasOne(x => x.Kullanici).WithMany(k => k.KullaniciRoller).HasForeignKey(x=>x.KullaniciId);
            builder.HasOne(x => x.Rol).WithMany(k => k.RolKullanicilar).HasForeignKey(x => x.RolId);
        }
    }
}
