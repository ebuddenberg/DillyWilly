using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.TableSets;
using DillyWilly.Models;

namespace DillyWilly.Utilities
{
    public static class Utilities
    {
        public static List<Movie> GetMovieList()
        {

            List<Movie> movies = new List<Movie>()
            {
                new Movie {
                    MovieId = 1,
                    ProductionDate = DateTime.Parse("2/18/2005"),
                    Title = "Iron Man",
                    Description = "There is a sinister attempt to destroy Tony Stark."
                },
                new Movie {
                    MovieId = 2,
                    ProductionDate = DateTime.Parse("5/22/2009"),
                    Title = "Travel Ban",
                    Description = " A B rated movie that did not make it very well"
                }
            };
            return movies;

        }
    }
}
