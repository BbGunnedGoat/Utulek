﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Utulek.Data;

#nullable disable

namespace Utulek.Migrations
{
    [DbContext(typeof(UtulekContext))]
    [Migration("20230428163154_MestoNalezu")]
    partial class MestoNalezu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Utulek.Models.Kocka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hmotnost")
                        .HasColumnType("int");

                    b.Property<string>("Jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plemeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pohlavi")
                        .HasColumnType("int");

                    b.Property<int>("Vek")
                        .HasColumnType("int");

                    b.Property<bool>("Volny")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Kocka");
                });

            modelBuilder.Entity("Utulek.Models.Pes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Hmotnost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MestoNalezu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plemeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pohlavi")
                        .HasColumnType("int");

                    b.Property<int>("Vek")
                        .HasColumnType("int");

                    b.Property<bool>("Volny")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pes");
                });
#pragma warning restore 612, 618
        }
    }
}