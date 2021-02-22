using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.TableSets
{
    public class MovieActors
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actors Actors { get; set; }

    }
}
