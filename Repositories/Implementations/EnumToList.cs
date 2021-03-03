using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
   public  class EnumToList
    { public string Description { get; set; }
       public  short Indice { get; set; }

        public EnumToList()
        {
            

        }

        public EnumToList( string desc, short indice)
        {
            Description = desc;
            Indice = indice;

        }

    }
}
