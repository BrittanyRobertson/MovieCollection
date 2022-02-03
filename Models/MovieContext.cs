using System;
using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        // seed the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );

            mb.Entity<ApplicationResponse>().HasData(
                    new ApplicationResponse
                    {
                        MovieId = 1,
                        CategoryId = 2,
                        Title = "Elf",
                        Year = "2003",
                        Director = "Jon Favreau",
                        Rating = "PG",
                        Edited = false
                    },
                    new ApplicationResponse
                    {
                        MovieId = 2,
                        CategoryId = 5,
                        Title = "Parasite",
                        Year = "2019",
                        Director = "Bong Joon-ho",
                        Rating = "R",
                        Edited = true,
                        Notes = "Won best movie"
                    },
                    new ApplicationResponse
                    {
                        MovieId = 3,
                        CategoryId = 1,
                        Title = "Spider-Man: No Way Home",
                        Year = "2021",
                        Director = "Jon Watts",
                        Rating = "PG-13",
                        Edited = false,
                        Notes = "I love Andrew Garfield"
                    }
                );
        }
    }
}