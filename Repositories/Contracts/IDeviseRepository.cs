﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
  public   interface IDeviseRepository
    {
        List<Devise> GetAll();
        Devise GetById(int id);
        Tiers GetByTiers(int id);
        Devise Add(Devise devise);
        Devise Update(Devise devise);
        bool Delete(int id);
        bool DeleteAdmin(int id);

    }
}
