using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = _context.Movies.SingleOrDefault();

            var customers = _context.Customers.ToList();

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //GET: movies/edit/id
        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(m=>m.Genre)
                .SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
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
            var movies = _context.Movies
                .Include(m=>m.Genre)
                .ToList();
            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(string year,string month)
        {
            return Content(year + "/" + month);
        }

        
    }
}