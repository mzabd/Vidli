using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidli.Dtos;
using Vidli.Models;

namespace Vidli.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        //application dbcontext for accessing db
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }
        //API for rental 
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            //get movies from db
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();
            //get customer from db
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            //add movie to rental db
            foreach (var movie in movies)
            {
                //first check if the movie is availabe
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not avialable");

                //reduce the NumberAvailable for each movie rental
                movie.NumberInStock--;

                //create a Rental object for each movie rental
                var rental = new Rental
                {
                    Csutomer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                //add Rental object to db
                _context.Rentals.Add(rental);
            }

            //save the changes in db
            _context.SaveChanges();

            //we are not using created method as we are not creating any single new object, 
            //also we need to supply url for new resource but here we are creating multiple resources
            return Ok();
        }
    }
}
