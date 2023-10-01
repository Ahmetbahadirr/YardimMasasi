using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class SurecTanimiMap : IEntityTypeConfiguration<SurecTanimi>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SurecTanimi> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            //b.HasOne(x => x.AnaKonu).WithMany(y=> y.AltKonular).HasForeignKey(x=> x.AnaKonuId);
        }
    }
}
