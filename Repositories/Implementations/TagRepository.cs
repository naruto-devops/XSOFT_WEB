using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public class TagRepository : ITagRepository
    {
      
        

        public List<Menu> GetAll()
        {
            var menus = new List<Menu>() {
                new Menu(){ _TAG = 1110, _Menu="Fournisseurs"},
                new Menu(){ _TAG = 1111, _Menu="Clients"},
                new Menu(){ _TAG = 1112, _Menu="Articles"},
                new Menu(){ _TAG = 0, _Menu="Structures"},
                new Menu(){ _TAG = 2015, _Menu="Stock"},
                new Menu(){ _TAG = 2001, _Menu="Vente"},
                new Menu(){ _TAG = 2005, _Menu="Achat"},
                new Menu(){ _TAG = 2010, _Menu="Réglement"},
                new Menu(){ _TAG = 4088, _Menu="Calcul PRI"},
                new Menu(){ _TAG = 4087, _Menu="Calcul des Besoins"},
                new Menu(){ _TAG = 4089, _Menu="Production"},
                new Menu(){ _TAG = 4095, _Menu="OT"},
                new Menu(){ _TAG = 2023, _Menu="Caisse"},
                new Menu(){ _TAG = 0, _Menu="Traitements"},
                new Menu(){ _TAG = 3000, _Menu="Etats"},
                new Menu(){ _TAG = 3100, _Menu="Indicateurs"},
                new Menu(){ _TAG = 3200, _Menu="Consultation"},
                new Menu(){ _TAG = 3001, _Menu="Etats & statistiques"},
                new Menu(){ _TAG = 1002, _Menu="Modifier Remise / Prix"},
                new Menu(){ _TAG = 1008, _Menu="Modifier Numéro Doc"},
                new Menu(){ _TAG = 0, _Menu="Sécurité"},
                new Menu(){ _TAG = 7000, _Menu="Paramétres"},
                new Menu(){ _TAG = 8025, _Menu="Société"},
                new Menu(){ _TAG = 9999, _Menu="Impression"},
                new Menu(){ _TAG = 7055, _Menu="Import/Export"},
                new Menu(){ _TAG = 1008, _Menu="Modifier Numéro Doc"},
                new Menu(){ _TAG = 4005, _Menu="Facture d'avoir"},
                new Menu(){ _TAG = 4015, _Menu="Modification Facture"},
                new Menu(){ _TAG = 4016, _Menu="Afficher les marges"},
                new Menu(){ _TAG = 1008, _Menu="Modifier Numéro Doc"},



            };
            try
            {
                return menus;
            }
            catch (Exception ex)
            {

               throw ex;
            }
           

        }


    }
}
