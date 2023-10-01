using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.BirimNesneler.Db;
using YardimMasasi.Nesneler.GorevNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class BirimMap : IEntityTypeConfiguration<Birim>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Birim> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
