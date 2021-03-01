using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   
    
        public class DetailDimensionRepository : IDetailDimensionRepository
        {

            XSoftContext _context;
            public DetailDimensionRepository(XSoftContext context)
            {
                _context = context;
            }


            public List<DetailDimension> GetAll()
            {
                var res = new List<DetailDimension>();
                try
                {
                    res = _context.DetailDimensions.Where(a => a.Deleted == false).ToList();
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }


            public DetailDimension GetById(int id)
            {
                try
                {
                    var res = _context.DetailDimensions.FirstOrDefault(r => r.ID.Equals(id));
                    return res;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DetailDimension Add(DetailDimension DetailDimension)
            {
                try
                {
                    _context.DetailDimensions.Add(DetailDimension);
                    _context.SaveChanges();
                    return DetailDimension;
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
                    var res = _context.DetailDimensions.FirstOrDefault(r => r.ID.Equals(id));
                    res.Deleted = true;
                    if (res != null)
                    {
                        _context.DetailDimensions.Update(res);
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
                    var res = _context.DetailDimensions.FirstOrDefault(r => r.ID.Equals(id));

                    if (res != null)
                    {
                        _context.DetailDimensions.Remove(res);
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
            public DetailDimension Update(DetailDimension DetailDimension)
            {

                try
                {
                    _context.Update(DetailDimension);
                    _context.SaveChanges();
                    return DetailDimension;
                }
                catch (Exception ex)
                {
                    throw ex;

                }

            }

           
        }
}
