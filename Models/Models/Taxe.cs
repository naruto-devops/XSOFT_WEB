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
        public bool TTaux { get; set; }
        public bool Type { get; set; }
        public string CompteComptable { get; set; }

        public string Code { get; set; }
        public bool NonProfitaire { get; set; }
        public bool Sens { get; set; }
        public string Regroup { get; set; }
        public double Assujet { get; set; }


        public virtual IEnumerable<Famille> TaxesAchat { get; set; }
        public virtual IEnumerable<Famille> TaxesVente { get; set; }


    }
}
