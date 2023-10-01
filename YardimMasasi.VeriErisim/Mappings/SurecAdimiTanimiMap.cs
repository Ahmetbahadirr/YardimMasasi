using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class SurecAdimiTanimiMap : IEntityTypeConfiguration<SurecAdimiTanimi>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SurecAdimiTanimi> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Birim).WithMany(y=> y.SurecAdimTanimlari).HasForeignKey(x=> x.BirimId);
            b.HasOne(x => x.SurecTanimi).WithMany(y => y.SurecAdimlari).HasForeignKey(x => x.SurecTanimiId);
        }
    }
}
