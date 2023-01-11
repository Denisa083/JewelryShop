﻿// <auto-generated />
using System;
using JewelryShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JewelryShop.Migrations
{
    [DbContext(typeof(JewelryShopContext))]
    [Migration("20230110165353_Vanzari")]
    partial class Vanzari
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JewelryShop.Models.Bijuterie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<int?>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int?>("ColectieID")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("ColectieID");

                    b.ToTable("Bijuterie");
                });

            modelBuilder.Entity("JewelryShop.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("JewelryShop.Models.Categorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategorieNume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("JewelryShop.Models.Colectie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Colect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Colectie");
                });

            modelBuilder.Entity("JewelryShop.Models.Bijuterie", b =>
                {
                    b.HasOne("JewelryShop.Models.Brand", "Brand")
                        .WithMany("Bijuterii")
                        .HasForeignKey("BrandID");

                    b.HasOne("JewelryShop.Models.Categorie", "Categorie")
                        .WithMany("Bijuterii")
                        .HasForeignKey("CategorieID");

                    b.HasOne("JewelryShop.Models.Colectie", "Colectie")
                        .WithMany("Bijuterii")
                        .HasForeignKey("ColectieID");

                    b.Navigation("Brand");

                    b.Navigation("Categorie");

                    b.Navigation("Colectie");
                });

            modelBuilder.Entity("JewelryShop.Models.Brand", b =>
                {
                    b.Navigation("Bijuterii");
                });

            modelBuilder.Entity("JewelryShop.Models.Categorie", b =>
                {
                    b.Navigation("Bijuterii");
                });

            modelBuilder.Entity("JewelryShop.Models.Colectie", b =>
                {
                    b.Navigation("Bijuterii");
                });
#pragma warning restore 612, 618
        }
    }
}
