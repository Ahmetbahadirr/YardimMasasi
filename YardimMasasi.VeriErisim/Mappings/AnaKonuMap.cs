using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AnaKonuNesneler.Db;

namespace YardimMasasi.VeriErisim.Mappings
{
    public class AnaKonuMap : IEntityTypeConfiguration<AnaKonu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AnaKonu> b)
        {
            b.HasKey(x=>x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();


        }

    }

}
