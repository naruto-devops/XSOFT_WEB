using System;
using System.Collections.Generic;
using Models.Models;
using Repositories.Implementations;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CollaborateurServices : ICollaborateurService
    {
        ICollaborateurRepository _CollaborateurRepository;

        public CollaborateurServices(ICollaborateurRepository collaborateur)
        {
            _CollaborateurRepository = collaborateur;
        }


        public Tiers CheckCollaborateur_ExistTiers(int id)
        {
            try
            {
                return _CollaborateurRepository.GetByTiers(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


        public Collaborateur CheckUser_ExistCollaborateur(int id)
        {

            Collaborateur result = new Collaborateur();
            try
            {
                result = _CollaborateurRepository.GetUserByCollaborator(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public  List<Collaborateur> GetAll()
        {
            List<Collaborateur> result = new List<Collaborateur>();
            try
            {
                result = _CollaborateurRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }       
        }
       public  Collaborateur GetById(int id)
        {
            try
            {
                return _CollaborateurRepository.GetById(id);
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
                _CollaborateurRepository.Add(collaborateur);

                return collaborateur;
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

                _CollaborateurRepository.Update(collaborateur);
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
                return _CollaborateurRepository.Delete(id);
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
                return _CollaborateurRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
