using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IFamille0Service
    {
        List<Famille0> GetAll();
        Famille0 GetById(int id);
        Famille0 Add(Famille0 famille0);
        Famille0 Update(Famille0 famille0);

        bool DeleteAdmin(int id);
        bool Delete(int id);
    }
}
