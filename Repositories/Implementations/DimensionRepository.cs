using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class DimensionRepository : IDimensionRepository
    {
        XSoftContext _context;
        public DimensionRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Dimension> GetAll()
        {
            var res = new List<Dimension>();
            try
            {
                res = _context.Dimensions.Where(a => a.Deleted == false).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public Dimension GetById(int id)
        {
            try
            {
                var res = _context.Dimensions.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dimension Add(Dimension Dimension)
        {
            try
            {
                _context.Dimensions.Add(Dimension);
                _context.SaveChanges();
                return Dimension;
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
                var res = _context.Dimensions.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Dimensions.Update(res);
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
                var res = _context.Dimensions.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.Dimensions.Remove(res);
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
        public Dimension Update(Dimension Dimension)
        {

            try
            {
                _context.Update(Dimension);
                _context.SaveChanges();
                return Dimension;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public DetailDimension GetByDetailDimension(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var Tiers = _context.DetailDimensions.FirstOrDefault(r => r.DimensionId.Equals(id));
                    return Tiers;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
