using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Dimension
    {   [Key]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description {get;set;}
        public string InfoLibre { get; set; }
        public bool Deleted { get; set; }

        public virtual IEnumerable<DetailDimension> DetailDimensions { get; set; }
        public virtual IEnumerable<ArticleGenerique> ArticleGeneriquesDim1 { get; set; }
        public virtual IEnumerable<ArticleGenerique> ArticleGeneriquesDim2 { get; set; }
    }
}
