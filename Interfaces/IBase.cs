using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DillyWilly.Interfaces
{
   public interface IBase
    {
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }

        public void Close();
        public void Save();


    }
}
