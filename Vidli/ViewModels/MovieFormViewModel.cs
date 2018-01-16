using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidli.Models;

namespace Vidli.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        //public Movie Movie { get; set; }
        //instead of usning movie class we can use only the properties required for the form as it using viewmodel
        //we also make them nullable so that intial default values are nont populated in form

        public int? Id { get; set; }

        [Required] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public short? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        //to set intial state we can use constructor

        //constructor for initializing new movie
        public MovieFormViewModel()
        {
            Id = 0; //so that the hidden field in form is populated
        }
        //constructor for initializing existing movie
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
        }
    }
}