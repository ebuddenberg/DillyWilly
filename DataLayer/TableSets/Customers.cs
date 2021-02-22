using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.TableSets
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Movie> Movies { get; set; }
      [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "First Name is Required"), MaxLength(100)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required"), MaxLength(100)]
        public string LastName { get; set; }

        public int MoviesRented { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode, ErrorMessage = "Invalid Zip Code")] 
        public string ZipCode { get; set; }

        [StringLength(2)]
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string StoreName { get; set; }


    }
}
