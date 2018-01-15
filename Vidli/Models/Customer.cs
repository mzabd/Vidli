using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidli.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer's Name")] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthdDate { get; set; }

        //to associate customer class with membership type we create a navigation property 
        //it is useful when we load an object and its related objects from db 

        public MembershipType MembershipType { get; set; }
        
        //(create foriegn key)
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }


    }
}

