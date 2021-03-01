using Microsoft.AspNetCore.Mvc;
using MovieApp_CoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_CoreMVC.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new Category();
            var myList = categories.GetAllCategories();
            return View(myList);
        }
    }
}
