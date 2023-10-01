using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class EkipAltKonuMap : IEntityTypeConfiguration<EkipAltKonu>
    {
        public void Configure(EntityTypeBuilder<EkipAltKonu> b)
        {
            b.HasKey(x => new { x.AltKonuId, x.EkipId });
            b.HasOne(x => x.AltKonu).WithMany(y => y.Ekipler).HasForeignKey(x => x.AltKonuId);
            b.HasOne(x => x.Ekip).WithMany(y => y.AltKonular).HasForeignKey(x => x.EkipId);
        }
    }
}
