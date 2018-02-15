using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidli.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        [Required]
        public Customer Csutomer { get; set; }
        [Required]
        public Movie Movie { get; set; }
    }
}