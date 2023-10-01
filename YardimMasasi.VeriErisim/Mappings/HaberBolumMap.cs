using Microsoft.EntityFrameworkCore;
using YardimMasasi.Nesneler.HaberNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class HaberBolumMap : IEntityTypeConfiguration<HaberBolum>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<HaberBolum> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.Haber).WithMany(y => y.Bolumler).HasForeignKey(x => x.HaberId);
            

        }
    }
}
