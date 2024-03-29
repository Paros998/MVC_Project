﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20210729052414_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MvcMovie.Models.Produkt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nazwa")
                        .HasColumnType("TEXT");

                    b.Property<double>("normaHigh")
                        .HasColumnType("REAL");

                    b.Property<double>("normaLow")
                        .HasColumnType("REAL");

                    b.Property<string>("typBadania")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("MvcMovie.Models.Raport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataRaportu")
                        .HasColumnType("TEXT");

                    b.Property<string>("NazwaZakladu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NrRaportu")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Odczyt1")
                        .HasColumnType("REAL");

                    b.Property<double>("Odczyt2")
                        .HasColumnType("REAL");

                    b.Property<double>("Odczyt3")
                        .HasColumnType("REAL");

                    b.Property<string>("Produkt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Seria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypOdczytu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Raport");
                });

            modelBuilder.Entity("MvcMovie.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JoinTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
