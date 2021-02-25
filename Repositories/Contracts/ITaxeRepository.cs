﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public interface ITaxeRepository
    {
        List<Taxe> GetAll();
        Taxe GetById(int id);
     
        Taxe Add(Taxe Taxe);
        Taxe Update(Taxe Taxe);
        Famille CheckTaxeExistFamille(int id);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}