﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCollection.Models;

namespace MovieCollection.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220202000223_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieCollection.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Director = "Jon Favreau",
                            Edited = false,
                            Rating = "PG",
                            Title = "Elf",
                            Year = "2003"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 5,
                            Director = "Bong Joon-ho",
                            Edited = true,
                            Notes = "Won best movie",
                            Rating = "R",
                            Title = "Parasite",
                            Year = "2019"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 1,
                            Director = "Jon Watts",
                            Edited = false,
                            Notes = "I love Andrew Garfield",
                            Rating = "PG-13",
                            Title = "Spider-Man: No Way Home",
                            Year = "2021"
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.ApplicationResponse", b =>
                {
                    b.HasOne("MovieCollection.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
