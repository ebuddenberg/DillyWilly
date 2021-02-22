using System;
using DataLayer;
using DillyWilly.Interfaces;

namespace DillyWilly.Models
{
    public class MovieAdminModel : IAdminFunctions<MoviesModel>
    {
        private readonly ApplicationInitializer _context;

        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Comments { get; set; }
        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public MovieAdminModel(ApplicationInitializer context)
        {
            _context = context;
        }

        public bool Exists(MoviesModel m)
        {
            try
            { 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return true;
        }

        public bool Create(MoviesModel m)
        {
            throw new NotImplementedException();
        }

        public bool Update(MoviesModel m)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MoviesModel m)
        {
            throw new NotImplementedException();
        }

        public bool Read(MoviesModel m)
        {
            throw new NotImplementedException();
        }
    }
}
