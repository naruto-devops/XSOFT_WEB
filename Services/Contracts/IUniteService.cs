using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IUniteService
    {
        List<Unite> GetAll();
        Unite GetById(int id);
        Unite Add(Unite unite);
        Unite Update(Unite unite);
        Famille CheckUnite_ExistFamille(int id);

        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
