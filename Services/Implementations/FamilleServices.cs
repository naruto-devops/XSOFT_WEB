using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class FamilleServices : IFamilleService
    {

        IFamilleRepository _FamilleRepository;

    public FamilleServices(IFamilleRepository familleRepository)
    {
            _FamilleRepository = familleRepository;
    }

    public List<Famille> GetAll()
    {
        List<Famille> result = new List<Famille>();
        try
        {
            result = _FamilleRepository.GetAll();
            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public Famille GetById(int id)
    {
        try
        {
            var res = _FamilleRepository.GetById(id);
            return res;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    public Famille Add(Famille Famille)
    {
        try
        {
            _FamilleRepository.Add(Famille);
            return Famille;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    public Famille Update(Famille Famille)
    {
        try
        {
            _FamilleRepository.Update(Famille);
            return Famille;
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
            return _FamilleRepository.Delete(id);
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

        public Famille CheckFamille0_ExistFamille(int id)
        {
            try
            {
                return _FamilleRepository.GetByFamille(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
