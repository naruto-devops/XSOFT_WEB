﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface ICollaborateurRepository
    {
        List<Collaborateur> GetAll();
        Collaborateur GetById(int id);
        Tiers GetByTiers(int id);
        Collaborateur Add(Collaborateur cbl);
        Collaborateur Update(Collaborateur cbl);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        Collaborateur GetUserByCollaborator(int id);
    }
}
