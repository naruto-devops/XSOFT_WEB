using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IFamille0Repository
    {
        List<Famille0> GetAll();
        Famille0 GetById(int id);
        Famille0 Add(Famille0 devise);
        Famille0 Update(Famille0 devise);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
