using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidli.Models;

namespace Vidli.Controllers.Api
{
    public class MoviesController : ApiController
    {
        //application dbcontext for accessing db
        private ApplicationDbContext _context;

        //intiialize it
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //as we return a list of object i.e customer by convention it will resoponse to 
        //GET/api/movies
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
