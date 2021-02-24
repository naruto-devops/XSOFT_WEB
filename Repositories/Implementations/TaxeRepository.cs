using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
  public   class TaxeRepository : ITaxeRepository
    {

        XSoftContext _context;
        public TaxeRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Taxe> GetAll()
        {
            var res = new List<Taxe>();
            try
            {
     
              res = _context.Taxes.Where(a => a.Deleted == false).ToList();
                return res;
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
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));
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
                _context.Taxes.Add(Taxe);
                _context.SaveChanges();
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
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Taxes.Update(res);
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
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.Taxes.Remove(res);
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
        public Taxe Update(Taxe Taxe)
            {

                try
                {
                    _context.Update(Taxe);
                    _context.SaveChanges();
                    return Taxe;
                }
                catch (Exception ex)
                {
                    throw ex;

                }

            }

      public Famille  CheckTaxeExistFamille(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var famille = _context.Famille.FirstOrDefault(r => r.TaxeVenteId.Equals(id)||r.TaxeAchatId.Equals(id));
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
