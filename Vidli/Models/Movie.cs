using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidli.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Name { get; set; }
        public Genre Genre { get; set; }

    
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Range(1,20)]
        [Display(Name = "Number In Stock")]
        public short NumberInStock { get; set; }

        //create a foriegn key for Genre
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

    }
}

//public DateTime DateAdded
//{
//get
//{
//    if (DateAdded == null)
//    {
//        DateAdded = DateTime.Now;
//    }
//    return DateAdded;
//}
//private set { DateAdded = value; }
//}