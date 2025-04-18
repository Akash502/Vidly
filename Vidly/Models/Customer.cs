﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? BirthDate  {get;set;}

        public bool IsSubscibedtoNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}