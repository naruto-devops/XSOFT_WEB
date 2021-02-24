using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
  public  interface IFamilleService
    {
        List<Famille> GetAll();
        Famille GetById(int id);
        Famille Add(Famille famille);
        Famille Update(Famille famille);
        Famille CheckFamille0_ExistFamille(int id);
        
         bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
