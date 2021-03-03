using Models.Models;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IUtilisateurService
    {
        List<Utilisateur> GetAll();
        Utilisateur GetById(int id);
        Utilisateur Add(Utilisateur cbl);
        Utilisateur Update(Utilisateur cbl);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        Utilisateur  CheckExistUser(string login, string pwd);
        Collaborateur CheckUser_ExistCollaborateur(int id);
        List<EnumToList> GetTypeUsers();
        Tiers CheckModificator_ExistTiers(int id);
        Tiers CheckCreator_ExistTiers(int id);
        
    }
}

