using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public class DetailDimensionServices : IDetailDimensionService
    {

        IDetailDimensionRepository _DetailDimensionRepository;

        public DetailDimensionServices(IDetailDimensionRepository dvs)
        {
            _DetailDimensionRepository = dvs;
        }

        public List<DetailDimension> GetAll()
        {
            List<DetailDimension> result = new List<DetailDimension>();
            try
            {
                result = _DetailDimensionRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DetailDimension GetById(int id)
        {
            try
            {
                var res = _DetailDimensionRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DetailDimension Add(DetailDimension DetailDimension)
        {
            try
            {
                _DetailDimensionRepository.Add(DetailDimension);
                return DetailDimension;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DetailDimension Update(DetailDimension DetailDimension)
        {
            try
            {
                _DetailDimensionRepository.Update(DetailDimension);
                return DetailDimension;
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
                return _DetailDimensionRepository.Delete(id);
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
                return _DetailDimensionRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



   }
}
