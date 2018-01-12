using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidli.Models;
using Vidli.ViewModels;

namespace Vidli.Controllers
{
    public class MoviesController : Controller
    {
        //for db access we need to declare a db context
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //proper way to do it: override dispose mehtod of base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            //included Eager loading for Genre
            var movies = _context.Movies.Include(m => m.Genre ).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)         
                return HttpNotFound();
            return View(movie);



        }

        //for form
        public ActionResult New()
        {
            //get list of genre to populate the dropbox in form
            var genres = _context.Genres.ToList();
            //initialize the MovieFromViewModel with gernes
            var viewModel = new MovieFormViewModel
            {
               Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        //populate data in form for edit
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            var genre = _context.Genres.ToList();

            //we need to initialize moveviewmodel for 
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genre
            };

            if (movie == null)
                return HttpNotFound();

            return View("MovieForm", viewModel);
        }

        //save data from form to db
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
           
            //if movie has no id
            if (movie.Id == 0)
            {
                //it is a new move, so add to context
                _context.Movies.Add(movie);
            }
            else
            {
                //get a single move data from db as per id
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                //it is an existing move, so update
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
            }

            //second: to persist this changes we need to 
            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }

        //update
    }
}