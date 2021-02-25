using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   public class UniteRepository : IUniteRepository
    {

        XSoftContext _context;
        public UniteRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Unite> GetAll()
        {
            var res = new List<Unite>();
            try
            {
                res = _context.Unites.Where(a => a.Deleted == false).ToList();
                return res;
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
                var res = _context.Unites.FirstOrDefault(r => r.ID.Equals(id));
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
                _context.Unites.Add(Unite);
                _context.SaveChanges();
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
                var res = _context.Unites.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Unites.Update(res);
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

        public bool DeleteAdmin(int id)
        {

            try
            {
                var res = _context.Unites.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.Unites.Remove(res);
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
        public Unite Update(Unite Unite)
        {

            try
            {
                _context.Update(Unite);
                _context.SaveChanges();
                return Unite;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }


        public Famille CheckUnite_ExistFamille(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var famille = _context.Famille.FirstOrDefault(r => r.UniteId.Equals(id));
                    return famille;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
