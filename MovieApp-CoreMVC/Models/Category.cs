using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_CoreMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

        public List<Category> GetAllCategories()
        {
            using (var context = new MovieContext())
            {
                return context.Set<Category>().ToList();
            }
        }
    }
}
