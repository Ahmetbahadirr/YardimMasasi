using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YardimMasasi.Nesneler.GorevNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class GorevIslemMap : IEntityTypeConfiguration<GorevIslem>
    {
        public void Configure(EntityTypeBuilder<GorevIslem> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x=>x.Gorev).WithMany(x=>x.Islemler).HasForeignKey(x=>x.GorevId);
           
        }
    }

}
