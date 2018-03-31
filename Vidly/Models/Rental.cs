﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        //[Key]
        //[Column(Order =1)]
        //public int CustomerId { get; set; }

        //[Key]
        //[Column(Order = 2)]
        //public int MovieId { get; set; }

    }
}