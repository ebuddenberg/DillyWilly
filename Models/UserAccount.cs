using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DillyWilly.Interfaces;

namespace DillyWilly.Models
{
    public class UserAccount: IUserAccount
    {
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

        public bool Create()
        {
            throw new NotImplementedException();
        }
    }
}
