using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using Services.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ClientServices : IClientService
    {

        IClientRepository _clientRepository;
        
        IParametresService _parametresService;
        public ClientServices(IClientRepository client, IParametresService parametres)
      
        {
            _clientRepository = client;
            _parametresService = parametres;
           
        }

     

        public List<Tiers> GetAll()
        {
            List<Tiers> result = new List<Tiers>();
            result = _clientRepository.GetAll();
            return result;
        }


        public Tiers GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public List<Contact> GetcontactByTiers(int TiersId)
        {
            List<Contact> result = new List<Contact>();
            result = _clientRepository.GetByTiers(TiersId);
            return result;
        }

        public Tiers Add(Tiers Tiers)
        {
            Tiers result = new Tiers();
            Parametres parametres = _parametresService.GetAll();

   
           
            if (!parametres.INCCLI)
            {
                if (!(CheckUnicCodification(Tiers.Numero)))
                {
                    Tiers.Type = 0;
                    _clientRepository.Add(Tiers);
                    result = Tiers;
                }
                else
                {
                    result = null;
                }

            }
            else 
            {
                

                Tiers.Numero = parametres.NUMCLI;
                while (CheckUnicCodification(Tiers.Numero))
                {
                    Tiers.Numero = Tiers.Numero.IncrementCode();

                }
                Tiers.Type = 0;
                result = _clientRepository.Add(Tiers);
                parametres.NUMCLI = Tiers.Numero;
                _parametresService.Update(parametres);


            }
            return result;
        }

        public Tiers Update( Tiers Tiers)
        {
            _clientRepository.Update( Tiers);
            return Tiers;
        }

        public bool Delete(int id)
        {
            return _clientRepository.Delete(id);

        }


        public bool CheckUnicCodification(string numero)
        {
            return _clientRepository.CheckUnicCodification(numero);
        }

        
        //public bool CheckTiers_ExistDocLig( int id)
        //{
        //    var result = _TiersRepository.GetByDocLig(id);
        //    return result != null;
        //}

        //public FamilleTier GetfamTier(int id)
        //{
        //    return _TiersRepository.GetFamilleTier(id);
        //}

    }
}
