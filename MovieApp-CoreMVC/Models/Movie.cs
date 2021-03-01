using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_CoreMVC.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name  { get; set; }
        public string Players { get; set; }
        public string Description { get; set; }
        public string ImageUrl  { get; set; } //1.jpg
        public int CategoryId { get; set; }

        public List<Movie> GetAllMovies()
        {
            using (var context= new MovieContext())
            {
                return context.Set<Movie>().ToList();
            }
        }

        public Movie GetById(int id)
        {
            using (var context = new MovieContext())
            {
                return context.Movies.FirstOrDefault(i=>i.MovieId == id);
            }
        }

    }
}
