using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Famille
    {
        public int ID {get;set;}
        public string CodeFamille { get; set; }
        public string Intitule { get; set; }
        
        public int SuiviStock { get; set; }
        public double Remise { get; set; }
        public bool Deleted { get; set; }
        //--linkFamille0
        public Famille0 Famille0 { get; set; }
        public int? Famille0Id { get; set; }
        //--LinkUnite
        public Unite Unite { get; set; }
        public int? UniteId { get; set; }

        //-- Taxe -- achat---
        public Taxe TaxeAchat { get; set; }
        public int? TaxeAchatId { get; set; }
        //Taxe -- Vente---
        public Taxe TaxeVente { get; set; }
        public int? TaxeVenteId { get; set; }


    }
}
