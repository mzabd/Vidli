using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidli.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Type { get; set; }
    }
}