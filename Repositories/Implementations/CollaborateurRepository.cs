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
   public class CollaborateurRepository : ICollaborateurRepository
    {
        XSoftContext _context;
        public CollaborateurRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Collaborateur> GetAll()
        {
            var res = new List<Collaborateur>();
            try
            {
                res = _context.Collaborateurs.Where(a => a.Deleted == false).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        public Collaborateur GetById(int id)
        {
            try
            {
                var res = _context.Collaborateurs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        public Collaborateur Add(Collaborateur collaborateur)
        {
            try
            {
                _context.Collaborateurs.Add(collaborateur);
                _context.SaveChanges();
                return collaborateur;

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
                var res = _context.Collaborateurs.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Collaborateurs.Update(res);
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

        public Collaborateur Update(Collaborateur collaborateur)
        {

            try
            {
                _context.Update(collaborateur);
                _context.SaveChanges();
                return collaborateur;

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
                    var Tiers = _context.Tiers.FirstOrDefault(r => r.CollaborateurId.Equals(id));
                    return Tiers;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Collaborateur GetUserByCollaborator(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var collaborateur = _context.Collaborateurs.FirstOrDefault(r => r.UtilisateurId.Equals(id));
                    return collaborateur;
                }
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
                var res = _context.Collaborateurs.FirstOrDefault(r => r.ID.Equals(id));
                
                if (res != null)
                {
                    _context.Collaborateurs.Remove(res);
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
