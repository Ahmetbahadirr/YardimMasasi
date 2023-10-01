using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.GorevNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class GorevMap : IEntityTypeConfiguration<Gorev>
    {
        public void Configure(EntityTypeBuilder<Gorev> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();
            b.HasOne(x => x.Surec).WithOne(g => g.Gorev).HasForeignKey<Surec>(x => x.Id);
        }
    }
}