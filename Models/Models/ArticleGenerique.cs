using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class ArticleGenerique
    {   [Key]
        public int ID { get; set; }
        public string Reference { get; set; }
        public string Design { get; set; }
       

        public string  Description { get; set; }
        public DateTime  DateCreation { get; set; }
        public DateTime  DateModifiction { get; set; }
        public decimal  PrixAchat { get; set; }
        public decimal  Coefficient { get; set; }
        public decimal  PrixVente { get; set; }
        public decimal  PrixTTC { get; set; }
        public int  SuiviStock { get; set; }
        public string  CodeFiscal { get; set; }
        public string  Pays { get; set; }
       
        public decimal  PUNet { get; set; }
        public bool  NotImp { get; set; }
        public decimal  Remise { get; set; }
        public string  CodeBarre { get; set; }
        public decimal  PrixAchatDernier { get; set; }
        public bool   Sommeil { get; set; }
        public bool  Conditionne { get; set; }
        public decimal  QteConditionne { get; set; }
        public string   ImageName { get; set; }
        public int  TypeArticle { get; set; }
        
        public int  Statut { get; set; }
        
        public string   Jointe1 { get; set; }
        public string  Jointe2 { get; set; }
        public decimal  Poids { get; set; }

        public string ReferenceFournisseur { get; set; }
        public int   EMBALLAGE { get; set; }
        public decimal   STOCKMIN { get; set; }
        public decimal  FEINTEPROD { get; set; }
        public int  DELAIAPPRO { get; set; }
        public decimal  FEINTAPPRO { get; set; }
        
        public string  LOTENCOURS { get; set; }
        public bool Deleted { get; set; }


        //Taxe ----Vente1-----
        public Taxe TaxeVente1 { get; set; }
        public int? TaxeVente1Id { get; set; }
        //Taxe ----Vente2-----
        public Taxe TaxeVente2 { get; set; }
        public int? TaxeVente2Id { get; set; }

        //Taxe ----Achat11-----
        public Taxe TaxeAchat1 { get; set; }
        public int? TaxeAchat1Id { get; set; }
        //Taxe ----Vente2-----
        public Taxe TaxeAchat2 { get; set; }
        public int? TaxeAchat2Id { get; set; }


        //Utilisateur --Createur------
        public Utilisateur Createur { get; set; }
        public int? CreateurId { get; set; }
        //Utilisateur -- modificateur---
        public Utilisateur Modificateur { get; set; }
        public int? ModificateurId { get; set; }

        //categorieTarif -- link---
        public ClassificationArticle ClassificationArticles { get; set; }
        public int? ClassificationArticleId { get; set; }

        //Unite -- link---
        public Unite Unites { get; set; }
        public int? UniteId { get; set; }
        //famille -- link---
        public Famille Familles { get; set; }
        public int? FamilleId { get; set; }

        //Diemnsion--Diemnsion1------
        public Dimension Dimension1 { get; set; }
        public int? Dimension1Id { get; set; }
        //Diemnsion --Diemnsion2------
        public Dimension Dimension2 { get; set; }
        public int? Dimension2Id { get; set; }
        //fournissseur --fournissseur------
        public Tiers FournisseurPrincipale { get; set; }
        public int? FournisseurPrincipaleId { get; set; }

    }
}
