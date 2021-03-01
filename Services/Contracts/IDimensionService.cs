using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public interface IDimensionService
    {
        List<Dimension> GetAll();
        Dimension GetById(int id);
        Dimension Add(Dimension dimension);
        Dimension Update(Dimension dimension);

        DetailDimension CheckDimension_ExistDetailDimension(int id);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
