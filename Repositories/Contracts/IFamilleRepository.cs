using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
  public   interface IFamilleRepository
    {
        List<Famille> GetAll();
        Famille GetById(int id);
        Famille Add(Famille devise);
        Famille Update(Famille devise);
        bool Delete(int id);
        Famille GetByFamille(int id);

    }
}
