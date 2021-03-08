using Models.Models;
using Repositories.Contracts;
using Repositories.Implementations;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class UtilisateurServices : IUtilisateurService
    {
        IUtilisateurRepository _UtilisateurRepository;

        public UtilisateurServices(IUtilisateurRepository utilisateur)
        {
                _UtilisateurRepository = utilisateur;
         
        }

       

        public List<Utilisateur> GetAll()
        {
            List<Utilisateur> result = new List<Utilisateur>();
            try
            {
                result = _UtilisateurRepository.GetAll();
                return result;
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
               var result = _UtilisateurRepository.CheckExistUser( login,  pwd);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<EnumToList> GetTypeUsers()
        {

            List<EnumToList> result = new List<EnumToList>();
            try
            {

                result = _UtilisateurRepository.GetTypeUsers();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Utilisateur GetById(int id)
        {
            Utilisateur result = new Utilisateur();


            try
            {
                result = _UtilisateurRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Utilisateur Add(Utilisateur uti)
        {
            try
            {
                _UtilisateurRepository.Add(uti);
                return uti;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Utilisateur Update(Utilisateur uti)
        {
            try
            {
                _UtilisateurRepository.Update(uti);
                return uti;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(int id)
        {
            var userCreateur = CheckCreator_ExistTiers(id);
            var userModificateur = CheckModificator_ExistTiers(id);
            var UserCollaborateur = CheckUser_ExistCollaborateur(id);

            var result = false;
            if ((UserCollaborateur == null)&&((userCreateur==null)&&(userModificateur==null)))
            {
                result = true;
                _UtilisateurRepository.Delete(id);
            }
            
            return result;
           

        }
        public bool DeleteAdmin(int id)
        {
            var userCreateur = CheckCreator_ExistTiers(id);
            var userModificateur = CheckModificator_ExistTiers(id);
            var UserCollaborateur = CheckUser_ExistCollaborateur(id);

            var result = false;
            if ((UserCollaborateur == null) && ((userCreateur == null) && (userModificateur == null)))
            {
                result = true;
                _UtilisateurRepository.DeleteAdmin(id);
            }

            return result;


        }
        public Collaborateur CheckUser_ExistCollaborateur(int id)
        {
            Collaborateur result = new Collaborateur();
            try
            {
                result = _UtilisateurRepository.GetUserByCollaborator(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Tiers CheckCreator_ExistTiers(int id)
        {
            Tiers result = new Tiers ();
            try
            {
               result=  _UtilisateurRepository.GetCreatorByTiers(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Tiers CheckModificator_ExistTiers(int id)
        {
            Tiers result = new Tiers();
            try
            {
                result = _UtilisateurRepository.GetModificatorByTiers(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

      
    }
}
