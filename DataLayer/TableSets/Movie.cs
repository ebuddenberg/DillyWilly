using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace DataLayer.TableSets
{
    [Table("Movie")]
    public class Movie
    {
        [Key] 
        public int MovieId { get; set; }    
        [StringLength(200)]
        public string Title { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Rating { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ProductionDate { get; set; }
        public ICollection<MovieActors> MovieActors { get; set; }
        public List<Actors> Actors { get; set; }



    }
}
