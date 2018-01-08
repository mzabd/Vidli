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
        public bool IsSubscribedToNewsletter { get; set; }

        //to associate customer class with membership type we create a navigation property 
        //it is useful when we load an object and its related objects from db 
        public MembershipType MembershipType { get; set; }
        //(create foriegn key)
        public byte MembershipTypeId { get; set; }


    }
}

