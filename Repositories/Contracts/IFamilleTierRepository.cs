﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IFamilleTierRepository
    {
        List<FamilleTier> GetAll();
        FamilleTier GetById(int id);
        Tiers GetByTiers(int id);
        FamilleTier Add(FamilleTier cbl);
        FamilleTier Update(FamilleTier cbl);
        bool Delete(int id);
        bool DeleteAdmin(int id);

    }
}
