using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YardimMasasi.Nesneler.KullaniciNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings.KullaniciModul
{
    public class RolMenuMap : IEntityTypeConfiguration<RolMenu>
    {
        public void Configure(EntityTypeBuilder<RolMenu> builder)
        {
            builder.HasKey(x => new { x.RolId, x.MenuId });
            builder.HasOne(x => x.Rol).WithMany(k => k.RolMenuler).HasForeignKey(x => x.RolId);
            builder.HasOne(x => x.Menu).WithMany(k => k.MenuRoller).HasForeignKey(x => x.MenuId);
        }
    }
}
