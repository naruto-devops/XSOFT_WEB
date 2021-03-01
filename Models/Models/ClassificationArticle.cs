using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class ClassificationArticle
    {   [Key]
        public int ID {get;set;}
        public string Code { get; set; }
        public string Libelle { get; set; }
        public int Niveau { get; set; }
        public bool Deleted { get; set; }
    }
}
