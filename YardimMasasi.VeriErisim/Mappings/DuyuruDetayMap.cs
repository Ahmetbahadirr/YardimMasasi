using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.DuyuruNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class DuyuruDetayMap : IEntityTypeConfiguration<DuyuruDetay>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DuyuruDetay> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Duyuru).WithMany(y => y.Detaylar).HasForeignKey(x => x.DuyuruId);
 
        }
    }
}
