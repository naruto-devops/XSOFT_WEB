using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IDimensionRepository
    {
        List<Dimension> GetAll();
        Dimension GetById(int id);
        DetailDimension GetByDetailDimension(int id);
        Dimension Add(Dimension Dimension);
        Dimension Update(Dimension Dimension);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
