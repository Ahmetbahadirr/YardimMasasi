using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.DuyuruNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class DuyuruMap : IEntityTypeConfiguration<Duyuru>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Duyuru> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

        }

    }

}
