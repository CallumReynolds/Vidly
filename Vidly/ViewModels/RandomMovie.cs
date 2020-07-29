using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovie
    {
        public Customer customer { get; set; }
        public Movie movie { get; set; }
    }
}