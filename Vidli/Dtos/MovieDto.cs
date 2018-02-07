using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidli.Models;

namespace Vidli.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Name { get; set; }

       // public Genre Genre { get; set; }


        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public short NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        //create a foriegn key for Genre
        public int GenreId { get; set; }
    }
}