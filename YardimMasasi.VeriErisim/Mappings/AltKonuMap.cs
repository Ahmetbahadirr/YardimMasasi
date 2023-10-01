using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AltKonuNesneler.Db;
using YardimMasasi.Nesneler.AnaKonuNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class AltKonuMap : IEntityTypeConfiguration<AltKonu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AltKonu> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.HasOne(x => x.AnaKonu).WithMany(y=> y.AltKonular).HasForeignKey(x=> x.AnaKonuId);
            b.HasOne(x => x.SurecTanimi).WithMany(y => y.AltKonular).HasForeignKey(x => x.SurecTanimiId).IsRequired(false);
        }
    }
}
