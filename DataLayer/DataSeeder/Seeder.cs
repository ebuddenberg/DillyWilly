using System;
using DataLayer.TableSets;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DataSeeder
{
   public  class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .HasData(
                    new Customers
                    {
                        Address = "56 Wedge Road West",
                        CellNumber = "566-788-9090",
                        City = "St. Louis",
                        State = "MO",
                        ZipCode = "23455",
                        DateAdded = DateTime.Today,
                        FirstName = "Michael",
                        LastName = "Cohaart",
                        Id = 2
                    },
            
                    new Customers
                    {
                        Id =3,
                        Address = "8532 Dewey Road",
                        CellNumber = "440-567-7861",
                        City = "Montville",
                        DateAdded = DateTime.Now,
                        FirstName = "Rebecca",
                        LastName = "Buddenberg",
                        State = "OH"
                    },
                    new Customers
                    {
                        Id = 4,
                        Address = "Zappy Dappy rd",
                        CellNumber = "222-566-7877",
                        City = "LapperDoodle",
                        DateAdded = DateTime.Now,
                        FirstName = "Jim",
                        LastName = "Shoe",
                        State = "OH"
                    }

                );
        }
    }
}
