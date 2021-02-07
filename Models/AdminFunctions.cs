using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DillyWilly.Controllers;
using DillyWilly.Interfaces;

namespace DillyWilly.Models
{
    public class AdminFunctions : IAdminFunctions<Movies>
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Comments { get; set; }

        public AdminFunctions()
        {
            
        }

        public bool Edit(Movies m)
        {
            throw new NotImplementedException();
        }

        public bool Create(Movies m)
        {
            throw new NotImplementedException();
        }

        public bool Update(Movies m)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Movies m)
        {
            throw new NotImplementedException();
        }

                public void Close()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
