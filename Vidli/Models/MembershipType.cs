﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidli.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } //by conventino there should be Id for primaryId in each table and EF will find it by name id or TableId
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [Required]
        public string MembershipName { get; set; }

        //to avoid magic number in  validation, delare some readonly static variable as below
        public static readonly byte Unknown = 0;

        public static readonly byte PayAsYouGo = 1;

    }
}