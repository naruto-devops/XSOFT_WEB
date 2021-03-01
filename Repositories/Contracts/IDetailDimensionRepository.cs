using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public interface IDetailDimensionRepository
    {
        List<DetailDimension> GetAll();
        DetailDimension GetById(int id);
       
        DetailDimension Add(DetailDimension detailDimension);
        DetailDimension Update(DetailDimension detailDimension);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
