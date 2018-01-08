using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidli.Models;
using Vidli.ViewModels;

namespace Vidli.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    // initialize a movie object
        //    //var movie=  new Movie{Name = "Shrek"};
        //    ////list of customer
        //    //List<Customer> customers = new List<Customer>
        //    //{
        //    //    new Customer{Id = 101, Name = "Customer1"},
        //    //    new Customer{Id = 102, Name = "Customer2"},
        //    //    new Customer{Id = 103, Name = "Customer3"},
        //    //};

        //    //create a viewsmodel object and initalize it
        //    //var viewModel = new RandomMovieViewModel
        //    //{
        //    //    Movie = movie,
        //    //    Customers = customers
        //    //};
        //    //we can pass data to view by controller property ViewData dictionary
        //    //ViewData["Movie"] = movie; //like using a key for the data
        //    //by usnig viewbag
        //    //ViewBag.Movie = movie;
        //    //it is better not using both of the above rather using model
        //    //return View(viewModel);  
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return Content("Hello");
        //    //return RedirectToAction("Index", "Home", new{page= 1}); //third one is annonymous object
        //}

        //using parameter in the route
        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        //optional parameter : retrun a list of movies //movies
        //public ActionResult Index(int? pageIndex, string sortBy) //? to make nullable
        //{
        //    //if page index is not specified the movie will displayed in page 1
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    //if sort by is not specified movies will be sort by their name
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content($"pageIndex={pageIndex} & sortBy={sortBy} ");
        //}

        
        //type: MVCAction4 for code snippet
        //for custom route: movies/released/{year}/{month}
        //we will use attribute route with url and constrains
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, byte month)
        {
            return Content(year + " / " + month);
        }
    }
}