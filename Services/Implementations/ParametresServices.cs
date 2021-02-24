using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;



namespace Services.Implementations
{
    public class ParametresServices : IParametresService
    {
        IParametresRepository _ParametresRepository;


        public ParametresServices(IParametresRepository parametres)
        {
            _ParametresRepository = parametres;
        }


        public Parametres GetAll()
        {
            try
            {
                return _ParametresRepository.GetAll();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }  

        public Parametres Update(Parametres parametres)
        {
            try
            {
                _ParametresRepository.Update(parametres);
                return parametres;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool GetIncrementTiers()
        {
            try
            {
                return _ParametresRepository.GetIncrTiers();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string GetNumeroTiers()
        {
            try
            {
                return _ParametresRepository.GetNumTiers();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string GetClientGeneral()

        {
            try
            {
                return _ParametresRepository.GetClientGeneral();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        

        public bool UpdateNUMCLI(string numcli)
        {
            try
            {
                numcli.IncrementCode();
                _ParametresRepository.UpdateNUMCLI(numcli);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


    }
}
