using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Tagaru"};

            var customers=new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //GET: movies/edit/id
        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if(String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    //return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //    return View(_movies);
        //}

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(string year,string month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }
    }
}