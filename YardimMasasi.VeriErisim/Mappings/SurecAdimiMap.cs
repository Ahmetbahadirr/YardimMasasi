using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class SurecAdimiMap : IEntityTypeConfiguration<SurecAdimi>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SurecAdimi> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Surec).WithMany(g => g.SurecAdimlari).HasForeignKey(x => x.SurecId);
            b.HasOne(x => x.Birim).WithMany(g => g.SurecAdimlari).HasForeignKey(x => x.BirimId);
        }

    }
}
