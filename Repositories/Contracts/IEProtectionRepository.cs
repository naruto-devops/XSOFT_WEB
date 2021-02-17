using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public  interface IEProtectionRepository
    {
        List<EProtection> GetByUser(int Id);
        EProtection Add(EProtection eprotection);
        bool Delete(int Id);
    }
}
