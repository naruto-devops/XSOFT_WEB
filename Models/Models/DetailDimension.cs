using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class DetailDimension
    {
        [Key]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string InfoLibre {get;set; }
        public bool Deleted { get; set; }

        //---linkdimension
        public Dimension Dimension { get; set; }
        public int? DimensionId { get; set; }
    }
}
