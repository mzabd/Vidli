using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidli.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    

    }
}

//model classes will use purely for domain classes
//we will introduce a new folder with viewmodel