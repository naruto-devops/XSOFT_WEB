using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Taxe
    {
        [Key]
        public int ID { get; set; }
        public  string Intitule { get; set; }
        public int TTaux { get; set; }
        public int Type { get; set; }
        public string CompteComptable { get; set; }
        public double Taux { get; set; }
        public string Code { get; set; }
        public bool NonProfitaire { get; set; }
        public int Sens { get; set; }
        public string Regroup { get; set; }
        public double Assujet { get; set; }
        public bool Deleted { get; set; }


        public virtual IEnumerable<Famille> TaxesAchat { get; set; }
        public virtual IEnumerable<Famille> TaxesVente { get; set; }


        public virtual IEnumerable<ArticleGenerique> TaxeVen1ArtGens { get; set; }
        public virtual IEnumerable<ArticleGenerique> TaxeVen2ArtGens { get; set; }
        public virtual IEnumerable<ArticleGenerique> TaxeAch1ArtGens { get; set; }
        public virtual IEnumerable<ArticleGenerique> TaxeAch2ArtGens { get; set; }


    }
}
