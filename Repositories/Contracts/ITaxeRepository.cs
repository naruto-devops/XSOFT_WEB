using Models.Models;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Implementations.EnumerableListsRepository;

namespace Repositories.Contracts
{
   public interface ITaxeRepository
    {
        List<Taxe> GetAll();
        Taxe GetById(int id);
     
        Taxe Add(Taxe Taxe);
        Taxe Update(Taxe Taxe);
        Famille CheckTaxeExistFamille(int id);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        List<EnumToList> GetSens();
        List<EnumToList> GetTaux();
        List<EnumToList> GetTypeTaxe();




    }
}
