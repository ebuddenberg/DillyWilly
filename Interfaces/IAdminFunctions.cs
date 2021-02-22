using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DillyWilly.Interfaces
{
   public interface IAdminFunctions<in T> : IBase
   {
       public bool Exists(T m);
       public bool Create(T m);
       public bool Update(T m);
       public bool Delete(T m);
       public bool Read(T m);
   }

   }

