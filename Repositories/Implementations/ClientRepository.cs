using Dapper;

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
    public class ClientRepository : IClientRepository
    {
        XSoftContext _context;
        public ClientRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Tiers> GetAll()
        {
            var res = new List<Tiers>();
            try
            {
                res = _context.Tiers.Where(a => a.Type == 0 && a.Deleted == false).ToList();

                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }


        public Tiers GetById(int id)
        {
            try
            {
                var res = _context.Tiers.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Contact> GetByTiers(int TiersId)
        {
            var res = new List<Contact>();
            try
            {
                res = _context.Contacts.Where(r => r.TiersId.Equals(TiersId)).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tiers Add(Tiers Tiers)
        {
            try
            {
                _context.Tiers.Add(Tiers);
                _context.SaveChanges();
                return Tiers;

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



                var res = _context.Tiers.FirstOrDefault(r => r.ID.Equals(id));
                
                res.Deleted = true;
                if (res != null)
                {
                    _context.Tiers.Update(res);
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

        public Tiers Update(Tiers Tiers)
        {

            try
            {
                _context.Update(Tiers);
                _context.SaveChanges();
                return Tiers;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }


        public bool CheckUnicCodification(string numero)
        {
                return _context.Tiers.Where(s => s.Numero.Equals(numero)).Any();
           

            
        }
    }
}
