using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class FournisseurServices : IFournisseurService
    {
        IFournisseurRepository _fournisseurRepository;
        IContactRepository _contactRepository;
        IParametresService _parametresService;

        public FournisseurServices(IFournisseurRepository fournisseur, IParametresService parametres, IContactRepository contact)

        {
            _fournisseurRepository = fournisseur;
            _parametresService = parametres;
            _contactRepository = contact;
        }

        

        public List<Tiers> GetAll()
        {
            List<Tiers> result = new List<Tiers>();
            result = _fournisseurRepository.GetAll();
            return result;
        }

        public string GetIncrement()
        {
            Parametres parametres = _parametresService.GetAll();
            return parametres.NUMFRS.IncrementCode();
        }

        public Tiers GetById(int id)
        {
            return _fournisseurRepository.GetById(id);
        }

        public List<Contact> GetcontactByTiers(int TiersId)
        {
            List<Contact> result = new List<Contact>();
            result = _fournisseurRepository.GetByTiers(TiersId);
            return result;
        }

        public Tiers Add(Tiers Tiers)
        {
            Tiers result = new Tiers();
            Parametres parametres = _parametresService.GetAll();



            if (!parametres.INCFRS)
            {
                if (!(CheckUnicCodification(Tiers.Numero)))
                {
                    Tiers.Type = 1;
                    _fournisseurRepository.Add(Tiers);
                    result = Tiers;
                }
                else
                {
                    result = null;
                }

            }
            else
            {


                Tiers.Numero = parametres.NUMFRS;
                while (CheckUnicCodification(Tiers.Numero))
                {
                    Tiers.Numero = Tiers.Numero.IncrementCode();

                }
                Tiers.Type = 1;
                result = _fournisseurRepository.Add(Tiers);
                parametres.NUMFRS = Tiers.Numero;
                _parametresService.Update(parametres);


            }
            return result;
        }

        public Tiers Update(Tiers Tiers)
        {
            _fournisseurRepository.Update(Tiers);
            return Tiers;
        }

        public bool Delete(int id)
        {
            return _fournisseurRepository.Delete(id);

        }


        public bool CheckUnicCodification(string numero)
        {
            return _fournisseurRepository.CheckUnicCodification(numero);
        }

       
    }
}
