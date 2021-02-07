using System;
using DillyWilly.Interfaces;

namespace DillyWilly.Models
{
    public class Movies : IBase
    {
        public string Name { get; set; }
        
        public string MovieDescription { get; set; }
        
        public DateTime ProductionDate { get; set; }
        
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
    }
}