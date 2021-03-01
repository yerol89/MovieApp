using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_CoreMVC.Models
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=(local);Trusted_Connection=True;Database=MovieAppDB");

            var options = optionsBuilder.Options;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .ToTable("Movies");
            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie
                    {
                        MovieId=1,
                        Players= "Matthew McConaughey,Mackenzie Foy",
                        Name = "Interstellar",
                        Description= "Set in a dystopian future where humanity is struggling to survive, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for mankind.",
                        ImageUrl="Interstellar_film_poster.jpg",
                        CategoryId = 1
                        
                    },
                    new Movie
                    {
                        MovieId = 2,
                        Players = "Keanu Reeves,Carrie-Anne Moss,Laurence Fishburne",
                        Name = "Matrix",
                        Description = "It depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, created by intelligent machines to distract humans while using their bodies as an energy source",
                        ImageUrl = "matrix.jpg",
                        CategoryId = 1

                    },
                     new Movie
                     {
                         MovieId = 3,
                         Players = "Leonardo DiCaprio,	Mark Ruffalo,Ben Kingsley",
                         Name = "Shutter Island",
                         Description = "The ending of “Shutter Island” reveals that DiCaprio's character is a patient himself, committed to the Shutter Island facility after murdering his wife (Michelle Williams) because she went insane and killed their children.",
                         ImageUrl = "shutterisland.jpg",
                         CategoryId = 4

                     },
                      new Movie
                      {
                          MovieId = 4,
                          Players = "Marlon Brando, Al Pacino, James Caan",
                          Name = "God Father",
                          Description = "The Godfather is a 1972 American crime film directed by Francis Ford Coppola, who co-wrote the screenplay with Mario Puzo, based on Puzo's best-selling 1969 novel of the same name. ",
                          ImageUrl = "godfather.jpg",
                          CategoryId = 3

                      },
                       new Movie
                       {
                           MovieId = 5,
                           Players = "Jim Carrey",
                           Name = "Aceventura",
                           Description = "Ace Ventura is a fictional character created by Canadian screenwriter Jack Bernstein. Ace was performed by Jim Carrey in the films Ace Ventura: Pet Detective, released in 1994, and Ace Ventura: When Nature Calls, released in 1995, and was voiced by Michael Daingerfield in the Ace Ventura: Pet Detective television series.",
                           ImageUrl = "aceventura.jpg",
                           CategoryId = 2

                       }
                );

            modelBuilder.Entity<Category>()
               .ToTable("Categories");
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        CategoryId = 1,
                        Name = "Science Fiction"
                    },
                    new Category
                    {
                        CategoryId = 2,
                        Name = "Comedy"
                    },
                    new Category
                    {
                        CategoryId = 3,
                        Name = "Drama"
                    },
                    new Category
                    {
                        CategoryId = 4,
                        Name = "Thriller"
                    },
                    new Category
                    {
                        CategoryId = 5,
                        Name = "Romance"
                    }

                );
        }
    }
    
}
