using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
   public class Utilisateur
    {   [Key]
         public int ID { get; set; }
        public string User { get; set; }
        public string ModePasse { get; set; }
        public string C_ModePasse { get; set; }
        public string Description { get; set; }
        public int Droit { get; set; }
        public DateTime Date_connexion { get; set; }
        public bool Deleted { get; set; }
       
       
        //--LinkTiers
        public virtual IEnumerable<Tiers> TiersModifies { get; set; }
        public virtual IEnumerable<Tiers> TiersCrees { get; set; }

        //--LinkCollaborateur
        public virtual IEnumerable<Collaborateur> Collaborateurs { get; set; }
        public virtual IEnumerable<EProtection> EProtections { get; set; }

        public virtual IEnumerable<ArticleGenerique> ArticleGenCrees { get; set; }
        public virtual IEnumerable<ArticleGenerique> ArticleGenModifies { get; set; }
    }
}
