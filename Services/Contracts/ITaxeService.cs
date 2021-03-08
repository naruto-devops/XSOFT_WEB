using Models.Models;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Implementations.EnumerableListsRepository;

namespace Services.Contracts
{
  public  interface ITaxeService
    {
        List<Taxe> GetAll();
        Taxe GetById(int id);
        Taxe Add(Taxe taxe);
        Taxe Update(Taxe taxe);
        Famille CheckTaxe_ExistFamille(int id);
        List<EnumToList> GetSens();
        List<EnumToList> GetTaux();
        List<EnumToList> GetTypeTaxe();

        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
