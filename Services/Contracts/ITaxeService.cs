using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
  public  interface ITaxeService
    {
        List<Taxe> GetAll();
        Taxe GetById(int id);
        Taxe Add(Taxe taxe);
        Taxe Update(Taxe taxe);
        Famille CheckTaxe_ExistFamille(int id);


        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
