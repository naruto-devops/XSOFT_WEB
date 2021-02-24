using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class EProtectionServices : IEProtectionService

    {
        IEProtectionRepository _EProtectionRepository;

        public EProtectionServices(IEProtectionRepository eProtection)
        {
            _EProtectionRepository = eProtection;
        }

        public List<EProtection> GetByUser(int Id)
        {
            List<EProtection> result = new List<EProtection>();
            try
            {
                result = _EProtectionRepository.GetByUser(Id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public EProtection Add(EProtection eprotection)
        {
             
            try
            {
                _EProtectionRepository.Add(eprotection);
                return eprotection;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
         public bool Delete(int Id)
        {
            try
            {
                return _EProtectionRepository.Delete(Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
