﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp_CoreMVC.Models;

namespace MovieApp_CoreMVC.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20210301122420_CategoryTable")]
    partial class CategoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieApp_CoreMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Thriller"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Romance"
                        });
                });

            modelBuilder.Entity("MovieApp_CoreMVC.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Players")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Description = "Set in a dystopian future where humanity is struggling to survive, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for mankind.",
                            ImageUrl = "Interstellar_film_poster.jpg",
                            Name = "Interstellar",
                            Players = "Matthew McConaughey,Mackenzie Foy"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Description = "It depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, created by intelligent machines to distract humans while using their bodies as an energy source",
                            ImageUrl = "matrix.jpg",
                            Name = "Matrix",
                            Players = "Keanu Reeves,Carrie-Anne Moss,Laurence Fishburne"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 4,
                            Description = "The ending of “Shutter Island” reveals that DiCaprio's character is a patient himself, committed to the Shutter Island facility after murdering his wife (Michelle Williams) because she went insane and killed their children.",
                            ImageUrl = "shutterisland.jpg",
                            Name = "Shutter Island",
                            Players = "Leonardo DiCaprio,	Mark Ruffalo,Ben Kingsley"
                        },
                        new
                        {
                            MovieId = 4,
                            CategoryId = 3,
                            Description = "The Godfather is a 1972 American crime film directed by Francis Ford Coppola, who co-wrote the screenplay with Mario Puzo, based on Puzo's best-selling 1969 novel of the same name. ",
                            ImageUrl = "godfather.jpg",
                            Name = "God Father",
                            Players = "Marlon Brando, Al Pacino, James Caan"
                        },
                        new
                        {
                            MovieId = 5,
                            CategoryId = 2,
                            Description = "Ace Ventura is a fictional character created by Canadian screenwriter Jack Bernstein. Ace was performed by Jim Carrey in the films Ace Ventura: Pet Detective, released in 1994, and Ace Ventura: When Nature Calls, released in 1995, and was voiced by Michael Daingerfield in the Ace Ventura: Pet Detective television series.",
                            ImageUrl = "aceventura.jpg",
                            Name = "Aceventura",
                            Players = "Jim Carrey"
                        });
                });

            modelBuilder.Entity("MovieApp_CoreMVC.Models.Movie", b =>
                {
                    b.HasOne("MovieApp_CoreMVC.Models.Category", null)
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieApp_CoreMVC.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
