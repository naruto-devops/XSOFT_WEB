using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class Famille0Services  : IFamille0Service
    {

        IFamille0Repository _Famille0Repository;

        public Famille0Services(IFamille0Repository Famille0Repository)
        {
            _Famille0Repository = Famille0Repository;
        }

        public List<Famille0> GetAll()
        {
            List<Famille0> result = new List<Famille0>();
            try
            {
                result = _Famille0Repository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Famille0 GetById(int id)
        {
            try
            {
                var res = _Famille0Repository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Famille0 Add(Famille0 Famille0)
        {
            try
            {
                _Famille0Repository.Add(Famille0);
                return Famille0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Famille0 Update(Famille0 Famille0)
        {
            try
            {
                _Famille0Repository.Update(Famille0);
                return Famille0;
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
                return _Famille0Repository.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        


    }
}
