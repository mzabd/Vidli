using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidli.Models;

namespace Vidli.ViewModels
{
    public class MovieFormViewModel
    {
        public object Name;
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}