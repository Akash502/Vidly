﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class RandomMovie
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}