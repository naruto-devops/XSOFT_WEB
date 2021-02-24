using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class ContactServices : IContactService
    {
        IContactRepository _ContactRepository;

        public ContactServices(IContactRepository contact)
        {
            _ContactRepository = contact;
        }

       

        public List<Contact> GetAll()
        {
            List<Contact> result = new List<Contact>();
            try
            {
                result = _ContactRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Contact GetById(int id)
        {
            try
            {
                return _ContactRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        public Contact Add(Contact contact)
        {
            try
            {
                _ContactRepository.Add(contact);
                return contact;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Contact Update(Contact contact)
        {
            try
            {
                _ContactRepository.Update(contact);
                return contact;
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
                return _ContactRepository.Delete(id);
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
                return _ContactRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
