using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.EkipNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class EkipMap : IEntityTypeConfiguration<Ekip>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ekip> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Birim).WithMany(y=> y.Ekipler).HasForeignKey(x=> x.BirimId);
        }
    }



}
