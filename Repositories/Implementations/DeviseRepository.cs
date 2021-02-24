using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class DeviseRepository : IDeviseRepository
    {
       
        XSoftContext _context;
        public DeviseRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Devise> GetAll()
        {
            var res = new List<Devise>();
            try
            {
                res = _context.Devises.Where(a => a.Deleted == false).ToList();
                return res;
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
                var res = _context.Devises.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }

        public Devise Add(Devise devise)
        {
            try
            {
                _context.Devises.Add(devise);
                _context.SaveChanges();
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
                var res = _context.Devises.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Devises.Update(res);
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

        public Devise Update(Devise devise)
        {

            try
            {
                _context.Update(devise);
                _context.SaveChanges();
                return devise;
            }
            catch (Exception ex)
            {
                throw ex;

            }
           
        }

        public Tiers GetByTiers(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var Tiers = _context.Tiers.FirstOrDefault(r => r.DeviseId.Equals(id));
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
