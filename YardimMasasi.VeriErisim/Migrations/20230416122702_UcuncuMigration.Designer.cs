﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YardimMasasi.VeriErisim;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    [DbContext(typeof(YardimMasasiContext))]
    [Migration("20230416122702_UcuncuMigration")]
    partial class UcuncuMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YardimMasasi.Nesneler.AltKonuNesneler.Db.AltKonu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnaKonuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AnaKonuId");

                    b.ToTable("AltKonu");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.AnaKonuNesneler.Db.AnaKonu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AnaKonu");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.BirimNesneler.Db.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Birim");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.EkipNesneler.Db.Ekip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.ToTable("Ekip");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.AltKonuNesneler.Db.AltKonu", b =>
                {
                    b.HasOne("YardimMasasi.Nesneler.AnaKonuNesneler.Db.AnaKonu", "AnaKonu")
                        .WithMany("AltKonular")
                        .HasForeignKey("AnaKonuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnaKonu");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.EkipNesneler.Db.Ekip", b =>
                {
                    b.HasOne("YardimMasasi.Nesneler.BirimNesneler.Db.Birim", "Birim")
                        .WithMany("Ekipler")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.AnaKonuNesneler.Db.AnaKonu", b =>
                {
                    b.Navigation("AltKonular");
                });

            modelBuilder.Entity("YardimMasasi.Nesneler.BirimNesneler.Db.Birim", b =>
                {
                    b.Navigation("Ekipler");
                });
#pragma warning restore 612, 618
        }
    }
}