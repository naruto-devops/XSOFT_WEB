using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Famille0
    {   [Key]
        public int ID {get;set;}
        public string Code { get; set; }
        public string Intitule { get; set; }
        public virtual IEnumerable<Famille> Familles { get; set; }
    }
}
