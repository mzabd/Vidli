using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidli.Models;

namespace Vidli.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required] //for db schema: make it not nullable
        [StringLength(255)] //to make nvarchar as 255
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        //[Min18YearsIfAMember] // for api we comment out it
        public DateTime? BirthdDate { get; set; }

        public MembershipTypeDto MembershipType { get; set; } 


        //(create foriegn key)
        public byte MembershipTypeId { get; set; }
    }
}