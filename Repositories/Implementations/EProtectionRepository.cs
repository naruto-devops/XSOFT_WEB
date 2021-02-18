using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class EProtectionRepository : IEProtectionRepository
    {

        XSoftContext _context;
        public EProtectionRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<EProtection> GetByUser(int id)
        {
            try
            {
                var res = _context.EProtections.Where(r => r.UtilisateurID.Equals(id)).ToList();
                return res;
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
                _context.EProtections.Add(eprotection);
                _context.SaveChanges();
                return eprotection;
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
                var res = _context.EProtections.FirstOrDefault(r => r.ID.Equals(id));
                
                if (res != null)
                {
                    _context.EProtections.Remove(res);
                    _context.SaveChanges();
                    return true;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw ex;

            }

        }



    }
}
