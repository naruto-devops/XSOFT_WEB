using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class DeviseServices : IDeviseService
    {

        IDeviseRepository _DeviseRepository;

        public DeviseServices(IDeviseRepository dvs)
        {
            _DeviseRepository = dvs;
        }

        public List<Devise> GetAll()
        {
            List<Devise> result = new List<Devise>();
            try
            {
                result = _DeviseRepository.GetAll();
                return result;
            } 
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Devise GetById(int id)
        {
            try
            {
                var res = _DeviseRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
       
        }

        public Devise Add(Devise devise)
        {
            try
            {
                _DeviseRepository.Add(devise);
                return devise;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Devise Update(Devise devise)
        {
            try
            {
                _DeviseRepository.Update(devise);
                return devise;
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
                return _DeviseRepository.Delete(id);
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
                return _DeviseRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public Tiers CheckDevise_ExistTiers(int id)
        {
            try
            {
                return _DeviseRepository.GetByTiers(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
                       
        }
    }
}
