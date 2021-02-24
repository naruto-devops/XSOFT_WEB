using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public class UniteServices: IUniteService
    {

        IUniteRepository _UniteRepository;

        public UniteServices(IUniteRepository dvs)
        {
            _UniteRepository = dvs;
        }

        public List<Unite> GetAll()
        {
            List<Unite> result = new List<Unite>();
            try
            {
                result = _UniteRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Unite GetById(int id)
        {
            try
            {
                var res = _UniteRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Unite Add(Unite Unite)
        {
            try
            {
                _UniteRepository.Add(Unite);
                return Unite;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Unite Update(Unite Unite)
        {
            try
            {
                _UniteRepository.Update(Unite);
                return Unite;
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
                return _UniteRepository.Delete(id);
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
                return _UniteRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
