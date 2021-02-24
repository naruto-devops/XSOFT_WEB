using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   public  class FamilleRepository : IFamilleRepository
    {

        XSoftContext _context;
        public FamilleRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Famille> GetAll()
        {
            var res = new List<Famille>();
            try
            {
                res = _context.Famille.ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public Famille GetById(int id)
        {
            try
            {
                var res = _context.Famille.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Famille GetByFamille(int id)
        {
            try
            {
                var res = _context.Famille.FirstOrDefault(r => r.Famille0Id.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Famille Add(Famille Famille)
        {
            try
            {
                _context.Famille.Add(Famille);
                _context.SaveChanges();
                return Famille;
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
                var res = _context.Famille.FirstOrDefault(r => r.ID.Equals(id));
               
                if (res != null)
                {
                    _context.Famille.Remove(res);
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

        public Famille Update(Famille Famille)
        {

            try
            {
                _context.Update(Famille);
                _context.SaveChanges();
                return Famille;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

       
    }
}
