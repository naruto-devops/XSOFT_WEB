using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public interface IEProtectionService
    {

        List<EProtection> GetByUser(int Id);
        EProtection Add(EProtection eprotection);
        bool Delete(int Id);
    }
}
