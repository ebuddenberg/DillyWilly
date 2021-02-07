using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DillyWilly.Models;

namespace DillyWilly.Utilities
{
    public static class Utilities
    {
        public static List<Movies> GetMovieList()
        {

            List<Movies> movies = new List<Movies>()
            {
                new Movies {
                    Id = 1,
                    ProductionDate = DateTime.Parse("2/18/2005"),
                    Name = "Iron Man",
                    MovieDescription = "There is a sinister attempt to destroy Tony Stark."
                },
                new Movies {
                    Id = 2,
                    ProductionDate = DateTime.Parse("5/22/2009"),
                    Name = "Travel Ban",
                    MovieDescription = " A B rated movie that did not make it very well"
                }
            };
            return movies;

        }
    }
}
