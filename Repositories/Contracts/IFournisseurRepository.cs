using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public interface IFournisseurRepository
    {
        List<Tiers> GetAll();
        Tiers GetById(int id);
        List<Contact> GetByTiers(int TiersId);
        Tiers Add(Tiers Tiers);
        Tiers Update(Tiers Tiers);
        bool CheckUnicCodification(string numero);
        bool Delete(int id);
    }
}
