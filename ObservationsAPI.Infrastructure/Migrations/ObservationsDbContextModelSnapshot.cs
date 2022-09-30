﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObservationsAPI.Infrastructure;

#nullable disable

namespace ObservationsAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ObservationsDbContext))]
    partial class ObservationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ObservationsAPI.Infrastructure.Observation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Applyed")
                        .HasColumnType("bit")
                        .HasColumnName("Aplicado");

                    b.Property<DateTime?>("CreateDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaCreacion");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Controles", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}