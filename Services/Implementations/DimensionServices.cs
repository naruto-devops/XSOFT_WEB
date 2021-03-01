using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class DimensionServices : IDimensionService
    {
         

        IDimensionRepository _DimensionRepository;

        public DimensionServices(IDimensionRepository dim)
        {
            _DimensionRepository = dim;
        }

        public List<Dimension> GetAll()
        {
            List<Dimension> result = new List<Dimension>();
            try
            {
                result = _DimensionRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Dimension GetById(int id)
        {
            try
            {
                var res = _DimensionRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Dimension Add(Dimension Dimension)
        {
            try
            {
                _DimensionRepository.Add(Dimension);
                return Dimension;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Dimension Update(Dimension Dimension)
        {
            try
            {
                _DimensionRepository.Update(Dimension);
                return Dimension;
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
                return _DimensionRepository.Delete(id);
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
                return _DimensionRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public DetailDimension CheckDimension_ExistDetailDimension(int id)
        {
            try
            {
                return _DimensionRepository.GetByDetailDimension(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
