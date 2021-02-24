using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
  public  class Unite
    {
        [Key]
        public int ID { get; set; }
        public string Libelle { get; set; }
        public bool Deleted { get; set; }
         public virtual IEnumerable<Famille> Familles{ get; set; }
    }
}
