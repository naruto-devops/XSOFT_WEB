using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
  public  class TaxeServices : ITaxeService
    {

        ITaxeRepository _TaxeRepository;

        public TaxeServices(ITaxeRepository dvs)
        {
            _TaxeRepository = dvs;
        }

        public List<Taxe> GetAll()
        {
            List<Taxe> result = new List<Taxe>();
            try
            {
                result = _TaxeRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Taxe GetById(int id)
        {
            try
            {
                var res = _TaxeRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Taxe Add(Taxe Taxe)
        {
            try
            {
                _TaxeRepository.Add(Taxe);
                return Taxe;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Taxe Update(Taxe Taxe)
        {
            try
            {
                _TaxeRepository.Update(Taxe);
                return Taxe;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return _TaxeRepository.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool DeleteAdmin(int id)
        {
            try
            {
                return _TaxeRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public Famille CheckTaxe_ExistFamille(int id)
        {
            try
            {
                return _TaxeRepository.CheckTaxeExistFamille(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



    }
}
