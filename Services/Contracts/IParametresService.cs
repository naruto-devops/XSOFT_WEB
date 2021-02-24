using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IParametresService
    {
        Parametres GetAll();
        Parametres Update(Parametres parametre);
      
        bool UpdateNUMCLI(string numcli);
        string GetNumeroTiers();
        bool GetIncrementTiers();
      string GetClientGeneral();
    }
}
