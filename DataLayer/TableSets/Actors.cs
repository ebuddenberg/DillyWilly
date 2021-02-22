using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataLayer.TableSets
{
    [Table("Actors")]
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        [StringLength(200)]
        public string FirstName { get; set; }
        [StringLength(200)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime DOB { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        public ICollection<MovieActors> MovieActors { get; set; }
    }
}