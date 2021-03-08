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
using static Repositories.Implementations.EnumerableListsRepository;

namespace Repositories.Implementations
{
   public class UtilisateurRepository :IUtilisateurRepository
    {
        XSoftContext _context;
        public UtilisateurRepository(XSoftContext context)
        {
            _context = context;
        }

        public List<Utilisateur> GetAll()
        {
            var res = new List<Utilisateur>();
            try 
            {
                res = _context.Utilisateurs.Where(a => a.Deleted == false).ToList();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
       
        public Utilisateur GetById(int id)
        {
            try
            {
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Utilisateur Add(Utilisateur Utilisateur)
        {
            try
            {
                _context.Utilisateurs.Add(Utilisateur);
                _context.SaveChanges();
                return Utilisateur;

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
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Utilisateurs.Update(res);
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
                var res = _context.Utilisateurs.FirstOrDefault(r => r.ID.Equals(id));
                
                if (res != null)
                {
                    _context.Utilisateurs.Remove(res);
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
        public Utilisateur Update(Utilisateur Utilisateur)
        {

            try
            {
                _context.Update(Utilisateur);
                _context.SaveChanges();
                return Utilisateur;
            }
            catch (Exception ex)
            {
                throw ex;

            }
           
        }

        public Tiers GetCreatorByTiers(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Tiers.Where(r => r.CREATEURId.Equals(id)).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public Tiers GetModificatorByTiers(int id)
        {
           
            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Tiers.Where(r => r.MODIFICATEURId.Equals(id)).FirstOrDefault();
                    return res;
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
                    var res = db.Collaborateurs.Where(r => r.UtilisateurId.Equals(id) ).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<EnumToList> GetTypeUsers()
        {

            List<EnumToList> listeItemSens = new List<EnumToList>();
            try
            {

                listeItemSens.Add(new EnumToList(UserDroitGC.Utilisateur.ToString(), (short)UserDroitGC.Utilisateur));
                listeItemSens.Add(new EnumToList(UserDroitGC.Administrateur.ToString(), (short)UserDroitGC.Administrateur));
                return listeItemSens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Utilisateur CheckExistUser(string login, string pwd)
        {

            try
            {
                using (var db = new XSoftContext())
                {
                    var res = db.Utilisateurs.Where(r =>( r.User.Equals(login) && r.ModePasse.Equals(pwd) && r.Deleted==false)).FirstOrDefault();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
