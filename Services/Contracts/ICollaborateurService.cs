using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface ICollaborateurService
    {
        List<Collaborateur> GetAll();
        Collaborateur GetById(int id);
        Collaborateur Add(Collaborateur cbl);
        Collaborateur Update(Collaborateur cbl);

        Collaborateur CheckUser_ExistCollaborateur(int id);

        
        Tiers CheckCollaborateur_ExistTiers(int id);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
