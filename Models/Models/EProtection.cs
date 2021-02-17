using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
   public  class EProtection
    {  public  int ID { get; set; }
        public int Droit { get; set; }


        //---- linkUtilisateur
        public Utilisateur Utilisateur { get; set; }
        public int? UtilisateurID { get; set; }
    }
}
