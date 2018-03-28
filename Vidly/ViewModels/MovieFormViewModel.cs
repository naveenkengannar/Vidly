using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public string Name { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genre { get; set; }
    }
}