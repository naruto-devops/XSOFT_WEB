using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class Famille0Repository : IFamille0Repository
    {
        XSoftContext _context;
        public Famille0Repository(XSoftContext context)
        {
            _context = context;
        }


        public List<Famille0> GetAll()
        {
            var res = new List<Famille0>();
            try
            {
                res = _context.Famille0.ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public Famille0 GetById(int id)
        {
            try
            {
                var res = _context.Famille0.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Famille0 Add(Famille0 Famille0)
        {
            try
            {
                _context.Famille0.Add(Famille0);
                _context.SaveChanges();
                return Famille0;
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
                var res = _context.Famille0.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Famille0.Update(res);
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
                var res = _context.Famille0.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.Famille0.Remove(res);
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

        public Famille0 Update(Famille0 Famille0)
        {

            try
            {
                _context.Update(Famille0);
                _context.SaveChanges();
                return Famille0;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }


    }
}
