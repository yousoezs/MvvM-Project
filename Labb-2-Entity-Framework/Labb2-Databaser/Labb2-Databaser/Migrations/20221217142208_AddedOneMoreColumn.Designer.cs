﻿// <auto-generated />
using System;
using Labb2_Databaser.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2Databaser.Migrations
{
    [DbContext(typeof(BokhandelDbContext))]
    [Migration("20221217142208_AddedOneMoreColumn")]
    partial class AddedOneMoreColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb2_Databaser.DbModels.Butiker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Butik")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Butiker__3214EC2736F840B5");

                    b.ToTable("Butiker", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Böcker", b =>
                {
                    b.Property<string>("Isbn13")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("ISBN13");

                    b.Property<int?>("FörfattarId")
                        .HasColumnType("int")
                        .HasColumnName("FörfattarID");

                    b.Property<int?>("Pris")
                        .HasColumnType("int");

                    b.Property<int?>("Sidor")
                        .HasColumnType("int");

                    b.Property<string>("Språk")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Titel")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("UtgivningsDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Isbn13")
                        .HasName("PK__Böcker__3BF79E039F4E5330");

                    b.HasIndex("FörfattarId");

                    b.ToTable("Böcker", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Författare", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Efternamn")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("Födelsedatum")
                        .HasColumnType("date");

                    b.Property<string>("Förnamn")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Författa__3214EC2769723AD1");

                    b.ToTable("Författare", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Förlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Företag")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Isbn13")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("ISBN13");

                    b.HasKey("Id")
                        .HasName("PK__Förlag__3214EC271A558003");

                    b.HasIndex("Isbn13");

                    b.ToTable("Förlag", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Kunder", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Efternam")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Förnamn")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Kunder__3214EC27728FC7B0");

                    b.ToTable("Kunder", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.LagerSaldo", b =>
                {
                    b.Property<int>("ButikId")
                        .HasColumnType("int")
                        .HasColumnName("ButikID");

                    b.Property<string>("Isbn")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("ISBN");

                    b.Property<int?>("Antal")
                        .HasColumnType("int");

                    b.HasKey("ButikId", "Isbn")
                        .HasName("PK__LagerSal__1191B8942DB7830D");

                    b.HasIndex("Isbn");

                    b.ToTable("LagerSaldo", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Ordrar", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("Antal")
                        .HasColumnType("int");

                    b.Property<int>("KundId")
                        .HasColumnType("int")
                        .HasColumnName("KundID");

                    b.Property<int?>("StyckPris")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__Ordrar__C3905BAF9C561485");

                    b.HasIndex("KundId");

                    b.ToTable("Ordrar", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.VTitlarPerFörfattare", b =>
                {
                    b.Property<string>("Lagervärde")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("Titlar")
                        .HasColumnType("int");

                    b.Property<int?>("Ålder")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("vTitlarPerFörfattare", (string)null);
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Böcker", b =>
                {
                    b.HasOne("Labb2_Databaser.DbModels.Författare", "Författar")
                        .WithMany("Böckers")
                        .HasForeignKey("FörfattarId")
                        .HasConstraintName("FK__Böcker__Författa__4222D4EF");

                    b.Navigation("Författar");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Förlag", b =>
                {
                    b.HasOne("Labb2_Databaser.DbModels.Böcker", "Isbn13Navigation")
                        .WithMany("Förlags")
                        .HasForeignKey("Isbn13")
                        .IsRequired()
                        .HasConstraintName("FK__Förlag__ISBN13__5CD6CB2B");

                    b.Navigation("Isbn13Navigation");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.LagerSaldo", b =>
                {
                    b.HasOne("Labb2_Databaser.DbModels.Butiker", "Butik")
                        .WithMany("LagerSaldos")
                        .HasForeignKey("ButikId")
                        .IsRequired()
                        .HasConstraintName("FK__LagerSald__Butik__46E78A0C");

                    b.HasOne("Labb2_Databaser.DbModels.Böcker", "IsbnNavigation")
                        .WithMany("LagerSaldos")
                        .HasForeignKey("Isbn")
                        .IsRequired()
                        .HasConstraintName("FK__LagerSaldo__ISBN__47DBAE45");

                    b.Navigation("Butik");

                    b.Navigation("IsbnNavigation");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Ordrar", b =>
                {
                    b.HasOne("Labb2_Databaser.DbModels.Kunder", "Kund")
                        .WithMany("Ordrars")
                        .HasForeignKey("KundId")
                        .IsRequired()
                        .HasConstraintName("FK__Ordrar__KundID__30F848ED");

                    b.Navigation("Kund");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Butiker", b =>
                {
                    b.Navigation("LagerSaldos");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Böcker", b =>
                {
                    b.Navigation("Förlags");

                    b.Navigation("LagerSaldos");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Författare", b =>
                {
                    b.Navigation("Böckers");
                });

            modelBuilder.Entity("Labb2_Databaser.DbModels.Kunder", b =>
                {
                    b.Navigation("Ordrars");
                });
#pragma warning restore 612, 618
        }
    }
}
