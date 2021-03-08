using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
  public  class EnumerableListsRepository
    {

        #region Taxe
        public enum SensTaxeGC
        {
            Deductible =0,
            Collecte =1
        }
       
        public enum TypeTaxeGC
        {
            TVADebit = 0,
            TVAEncaissement = 1,
            TPHT = 2,
            TPTTC = 3,
            TPPoids = 4,
            TVACEE = 5,
            Surtaxe = 6,
            Vide = -1,
           
        }

        public enum TypeTauxGC
        {
            Taux = 0,
            Montant = 1,
            Quantite = 2
        }

        #endregion

        public enum TypeAtelier
        {
            Interne = 0,
            Récéption = 1


        }

        public enum TypeRessource
        {
            Ressource_Humaine = 0,
            Materiel = 1


        }

        public enum ProdSens
        {
            Entrée = 0,
            Sortie = 1
        }

        public enum TypeMouvement : short
        {
            In = 1,
            Out = 3
        }

        
        public enum ChoixRemiseGC
        {
            Manuel = 0,
            Article = 1,
            Famille = 2,
            Fournisseur = 3,
            Cumule = 4,
            Cascade = 5
        }


        public enum TypeAnnonce
        {
            Simple = 1,
            Encadre = 2,
            FondNoir = 3,
            Dechet = 4,

            Abonnement = 5,
            TravauxL = 6

        }


        public enum CategorieAnnonce
        {
            Annonce = 0,
            VenteDechet = 1,
            Abonnement = 2


        }

        public enum TypePublication
        {
            PetiteAnnonce = 0,
            GrandPlacard = 1
        }

        public enum NiveauCatalogue
        {
            Parent = 0,
            Fils1 = 1,
            Fils2 = 2,
            Fils3 = 3
        }

        

        public enum EtatOrdre
        {
            Cree = 0,
            Lance = 1,
            Solde = 2,
            Annule = 3
        }

        public enum EtatSousPhase
        {
            Créé = 0,
            EnCours = 1,
            Terminé = 2
        }

        public enum TypeRemiseGC
        {
            Montant = 0,
            Pourcentage = 1,
            Quantité = 2
        }

        public enum TypeCatComptaGC : short
        {
            Vente = 0,
            Achat = 1,
            Stiock = 2
        }


        public enum TypeGammeGC
        {
            Gamme = 0,
            EnumGammme = 1
        }

       

        public enum TypeEnregistrementGC
        {
            Entete = 0,
            Ligne = 1,
            Reglement = 2
        }

        public enum EtatFacture
        {
            NonRegle = 0,
            PartiellementRegle = 1,
            TotalementRegle = 2
        }

        public enum EtatReglement
        {
            NonAffect = 0,
            PartiellementAffect = 1,
            TotalementAffect = 2
        }

        public enum TypeReglement
        {
            Espèce = 0,
            Chèque = 1,
            Traite = 2,
            Virement = 3
        }

        public enum TypeJournaleGC
        {
            Achats = 0,
            Ventes = 1,
            Trésorerie = 2,
            Générale = 3,
            Situation = 4
        }

        public enum TypeFamilleGC
        {
            Détail = 0,
            Total = 1,
            Centralisateur = 2
        }

        public enum TypeArticleGC
        {
            Standard = 0,
            Nomenclature = 1,
            Gamme = 2
        }

        public enum StatutArticleGC
        {
            Generique = 0,
            Dimension = 1,
            Autre = 2
        }

        public enum StatutDocument
        {
            Saisi = 0,
            Validé = 1

        }

        public enum Mode
        {
            Ajouter = 0,
            Modifier = 1
        }

       
       


        public enum NatureCompteGeneraleGC
        {
            Aucune = 0,
            Client = 1,
            Fournisseur = 2,
            Salarié = 3,
            Banque = 4,
            Caisse = 5,
            Amortissement_Provision = 6,
            Résultat_bilan = 7,
            charge = 8,
            Produit = 9,
            Résultat_Gestion = 10,
            Immobilisation = 11,
            Capitaux = 12,
            Stock = 13,
            Titre = 14
        }

        public enum ArticleTypeGC
        {
            Standard = 0,
            Gamme = 1,
            RessourceUnit = 2,
            RessourceMult = 3
        }

        public enum PageGP
        {
            LaUne = 1,
            Deuxieme = 2,
            Troisieme = 3,
            Quatre = 4,
            Cinq = 5,
            Six = 6,
            Sept = 7,
            Huite = 8,
            Neuf = 9,
            Dix = 10,
            Onze = 11,
            Douze = 12,
            Treize = 13,
            Quatorze = 14,
            Quinze = 15,
            Seize = 16,
            DixSept = 17,
            DixHuit = 18,
            DixNeuf = 19,
            Vingt = 20,
            VingtEtUne = 21,
            VingtDeux = 22,
            Couverture = 94,
            Speciale = 95,
            Culture = 96,
            InternePaire = 97,
            InterneImpaire = 98,
            AvDernier = 99,
            Dernier = 100
        }

        public enum ImpressionGP
        {
            NoirBlanc = 1,
            FondNoir = 2,
            Couleur = 3
        }

        public enum TailleGP
        {
            Un1 = 1,
            Un2 = 2,
            Un4 = 4,
            Un8 = 8,
            Dimension = 9
        }

       
        public enum DomaineGC
        {
            Vente = 0,
            Achat = 1,
            Stock = 2
        }
     

        public enum EtatGC
        {
            New,
            Loaded,
            Deleted,
            Fictive
        }

      
        public enum NotificationTypeGC : short
        {
            Ajout = 4,
            Suppression = 6
        }

        public enum ControlArticleGC : short
        {
            TxtRef = 0,
            TxtDesign = 1,
            TxtMontant = 2,
            txtFamille = 3
        }


       
        public enum SuiviStockGC : short
        {
            Aucun = 0,
            Serialise = 1,
            CMUP = 2,
            FIFO = 3,
            LIFO = 4,
            CMUP_Lot = 5
        }

        public enum TarifCalculGC
        {
            Global = 1,
            Tranche = 0
        }

        public enum TarifObjectifGC
        {
            Montant = 1,
            Quantite = 0
        }

        public enum TarifTypeGC
        {
            Commision = 0,
            Rabais = 1,
            Promotion = 2
        }

       

        public enum TypeFactureGC : short
        {
            Facture = 0,
            Retour = 1,
            Avoir = 2
        }

        
        public enum TypeEmplacementGC : short
        {
            Standard = 0,
            Transit = 1,
            Controle = 2
        }

      
        public enum TypeFileGC
        {
            F_COMPTET,
            F_ARTICLE,
            F_DOCENTETE,
            F_DOCLIGNE
        }
       
        public enum TypeValeurGC
        {
            Text = 9,
            Montant = 20,
            Table = 22,
            Date = 3,
            DateLongue = 14,
            Valeur = 7
        }

        public enum CotationGC
        {
            Certain = 0,
            Incertain = 1
        }

        public enum TypeDocumentGC : short
        {
            DV_Vente = 0,
            BC_Vente = 1,
            BL_Vente = 3,
            BR_Vente = 4,
            FA_Vente = 6,
            FC_Vente = 7,
            AV_Vente = 5,
            BI = 44,
            PC_Achat = 11,
            BC_Achat = 12,
            BL_Achat = 13,
            BR_Achat = 14,
            AV_Achat = 15,
            FA_Achat = 16,
            FC_Achat = 17,
            ME = 20,
            MS = 21,
            MT = 23,
            MSProd = 24  
        }

        public enum TypeDroitGC
        {

            Lire = 3,
            Ecriture = 2,
            Suppression = 1
        }

        public enum UserDroitGC
        {
            Utilisateur = 0,
            Administrateur = 1
        }


    }
}
