using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YardimMasasi.Nesneler.GorevNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class GorevMesajMap : IEntityTypeConfiguration<GorevMesaj>
    {
        public void Configure(EntityTypeBuilder<GorevMesaj> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Gorev).WithMany(x => x.Mesajlar).HasForeignKey(x => x.GorevId);
        }
    }

}
