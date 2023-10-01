using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.GorevNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class SurecMap : IEntityTypeConfiguration<Surec>
    {
       
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Surec> b)
        {
            b.HasKey(x => x.Id);
            b.HasOne(x => x.SurecTanimi).WithMany(g => g.Surecler).HasForeignKey(x => x.SurecTanimiId);
        }
    }
}
