using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.HaberNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class HaberMap : IEntityTypeConfiguration<Haber>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Haber> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
