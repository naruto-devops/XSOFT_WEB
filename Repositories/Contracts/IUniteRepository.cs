using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IUniteRepository
    {
         
        List<Unite> GetAll();
        Unite GetById(int id);
      
        Unite Add(Unite Unite);
        Unite Update(Unite Unite);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        Famille CheckUnite_ExistFamille(int id);
    }

}
