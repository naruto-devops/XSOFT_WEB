using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Repositories.Implementations.EnumerableListsRepository;

namespace Repositories.Implementations
{
  public   class TaxeRepository : ITaxeRepository
    {
       

        XSoftContext _context;
        public TaxeRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<Taxe> GetAll()
        {
            var res = new List<Taxe>();
            try
            {
     
              res = _context.Taxes.Where(a => a.Deleted == false).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public List<EnumToList> GetSens()
        {

            List<EnumToList> listeItemSens = new List<EnumToList>();
            try
            {

                listeItemSens.Add(new EnumToList(SensTaxeGC.Deductible.ToString(), (short)SensTaxeGC.Deductible));
                listeItemSens.Add(new EnumToList(SensTaxeGC.Collecte.ToString(), (short)SensTaxeGC.Collecte));
                return listeItemSens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EnumToList> GetTaux()
        {
            List<EnumToList> listeItemTaux = new List<EnumToList>();
            try
            {

                listeItemTaux.Add(new EnumToList(TypeTauxGC.Taux.ToString(), (short)TypeTauxGC.Taux));
                listeItemTaux.Add(new EnumToList(TypeTauxGC.Montant.ToString(), (short)TypeTauxGC.Montant));
                listeItemTaux.Add(new EnumToList(TypeTauxGC.Quantite.ToString(), (short)TypeTauxGC.Quantite));
            
                return listeItemTaux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public  List<EnumToList> GetTypeTaxe()
        {
            List<EnumToList> listeItemType = new List<EnumToList>();
            try
            {

                listeItemType.Add(  new EnumToList( TypeTaxeGC.TVADebit.ToString() , (short)TypeTaxeGC.TVADebit));
                listeItemType.Add(new EnumToList(TypeTaxeGC.TVAEncaissement.ToString(), (short)TypeTaxeGC.TVAEncaissement));
                listeItemType.Add(new EnumToList(TypeTaxeGC.TPHT.ToString(), (short)TypeTaxeGC.TPHT));
                listeItemType.Add(new EnumToList(TypeTaxeGC.TPTTC.ToString(), (short)TypeTaxeGC.TPTTC));
                listeItemType.Add(new EnumToList(TypeTaxeGC.TPPoids.ToString(), (short)TypeTaxeGC.TPPoids));
                listeItemType.Add(new EnumToList(TypeTaxeGC.TVACEE.ToString(), (short)TypeTaxeGC.TVACEE));
                listeItemType.Add(new EnumToList(TypeTaxeGC.Surtaxe.ToString(), (short)TypeTaxeGC.Surtaxe));
                return listeItemType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Taxe GetById(int id)
        {
            try
            {
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Taxe Add(Taxe Taxe)
        {
            try
            {
                _context.Taxes.Add(Taxe);
                _context.SaveChanges();
                return Taxe;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Delete(int id)
        {

            try
            {
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.Taxes.Update(res);
                    _context.SaveChanges();
                    return true;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw ex;

            }

        }


        public bool DeleteAdmin(int id)
        {

            try
            {
                var res = _context.Taxes.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.Taxes.Remove(res);
                    _context.SaveChanges();
                    return true;
                }
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public Taxe Update(Taxe Taxe)
            {

                try
                {
                    _context.Update(Taxe);
                    _context.SaveChanges();
                    return Taxe;
                }
                catch (Exception ex)
                {
                    throw ex;

                }

            }

      public Famille  CheckTaxeExistFamille(int id)
        {
            try
            {
                using (var db = new XSoftContext())
                {
                    var famille = _context.Famille.FirstOrDefault(r => r.TaxeVenteId.Equals(id)||r.TaxeAchatId.Equals(id));
                    return famille;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
  }  
    

}
