using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IClientService
    {
        List<Tiers> GetAll();
        Tiers GetById(int id);
        List<Contact> GetcontactByTiers(int TiersId);
        Tiers Add(Tiers Tiers);
        Tiers Update( Tiers Tiers);
        bool CheckUnicCodification(string numero);
        bool Delete(int id);
        //bool CheckTiers_ExistDocLig(int id);

        //FamilleTier GetfamTier(int id); 
       
    }
}