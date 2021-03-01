using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
  public   interface IDetailDimensionService
    {
        List<DetailDimension> GetAll();
        DetailDimension GetById(int id);
        DetailDimension Add(DetailDimension cbl);
        DetailDimension Update(DetailDimension cbl);

       
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
