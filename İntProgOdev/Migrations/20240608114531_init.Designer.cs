﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using İntProgOdev.Models;

#nullable disable

namespace İntProgOdev.Migrations
{
    [DbContext(typeof(OkulDBContext))]
    [Migration("20240608114531_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("İntProgOdev.Models.Ders", b =>
                {
                    b.Property<int>("Dersid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dersid"));

                    b.Property<string>("DersAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("DersKodu")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar");

                    b.Property<int>("Kredi")
                        .HasColumnType("int");

                    b.HasKey("Dersid");

                    b.ToTable("tblDersler", (string)null);
                });

            modelBuilder.Entity("İntProgOdev.Models.Ogrenci", b =>
                {
                    b.Property<int>("Ogrenciid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ogrenciid"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<int>("Numara")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar");

                    b.HasKey("Ogrenciid");

                    b.ToTable("tblOgrenciler", (string)null);
                });

            modelBuilder.Entity("İntProgOdev.Models.RelationShips.OgrenciDers", b =>
                {
                    b.Property<int>("Ogrenciid")
                        .HasColumnType("int");

                    b.Property<int>("Dersid")
                        .HasColumnType("int");

                    b.HasKey("Ogrenciid", "Dersid");

                    b.HasIndex("Dersid");

                    b.ToTable("tblOgrenciDersler", (string)null);
                });

            modelBuilder.Entity("İntProgOdev.Models.RelationShips.OgrenciDers", b =>
                {
                    b.HasOne("İntProgOdev.Models.Ders", "Ders")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("Dersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("İntProgOdev.Models.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDersler")
                        .HasForeignKey("Ogrenciid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("İntProgOdev.Models.Ders", b =>
                {
                    b.Navigation("OgrenciDersler");
                });

            modelBuilder.Entity("İntProgOdev.Models.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDersler");
                });
#pragma warning restore 612, 618
        }
    }
}
