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
    public class ArticleGeneriqueRepository : IArticleGeneriqueRepository
    {
        XSoftContext _context;

        public ArticleGeneriqueRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<ArticleGenerique> GetAll()
        {
            var res = new List<ArticleGenerique>();
            try
            {
                res = _context.ArticlesGeneriques.Where(a => a.Deleted == false).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public ArticleGenerique GetById(int id)
        {
            try
            {
                var res = _context.ArticlesGeneriques.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckUnicReference(string reference)
        {
            return _context.ArticlesGeneriques.Where(s => s.Reference.Equals(reference)).Any();
        }
        public ArticleGenerique Add(ArticleGenerique ArticleGenerique)
        {
            try
            {
                _context.ArticlesGeneriques.Add(ArticleGenerique);
                _context.SaveChanges();
                return ArticleGenerique;
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
                var res = _context.ArticlesGeneriques.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.ArticlesGeneriques.Update(res);
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
                var res = _context.ArticlesGeneriques.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.ArticlesGeneriques.Remove(res);
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
        public ArticleGenerique Update(ArticleGenerique ArticleGenerique)
        {

            try
            {
                _context.Update(ArticleGenerique);
                _context.SaveChanges();
                return ArticleGenerique;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }




        public List<EnumToList> GetTypes()
        {

            List<EnumToList> listeItemSens = new List<EnumToList>();
            try
            {

                listeItemSens.Add(new EnumToList(TypeArticleGC.Standard.ToString(), (short)TypeArticleGC.Standard));
                listeItemSens.Add(new EnumToList(TypeArticleGC.Nomenclature.ToString(), (short)TypeArticleGC.Nomenclature));
                listeItemSens.Add(new EnumToList(TypeArticleGC.Gamme.ToString(), (short)TypeArticleGC.Gamme));
                return listeItemSens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<EnumToList> GetStatus()
        {
           
            List<EnumToList> listeItemSens = new List<EnumToList>();
            try
            {

                listeItemSens.Add(new EnumToList(StatutArticleGC.Generique.ToString(), (short)StatutArticleGC.Generique));
                listeItemSens.Add(new EnumToList(StatutArticleGC.Dimension.ToString(), (short)StatutArticleGC.Dimension));
                listeItemSens.Add(new EnumToList(StatutArticleGC.Autre.ToString(), (short)StatutArticleGC.Autre));
                return listeItemSens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<EnumToList> GetSuiviStock()
        {

            List<EnumToList> listeItemSens = new List<EnumToList>();
            try
            {

                listeItemSens.Add(new EnumToList(SuiviStockGC.CMUP_Lot.ToString(), (short)SuiviStockGC.CMUP_Lot));
                listeItemSens.Add(new EnumToList(SuiviStockGC.LIFO.ToString(), (short)SuiviStockGC.LIFO));
                listeItemSens.Add(new EnumToList(SuiviStockGC.FIFO.ToString(), (short)SuiviStockGC.FIFO));
                listeItemSens.Add(new EnumToList(SuiviStockGC.CMUP.ToString(), (short)SuiviStockGC.CMUP));
                listeItemSens.Add(new EnumToList(SuiviStockGC.Serialise.ToString(), (short)SuiviStockGC.Serialise));
                listeItemSens.Add(new EnumToList(SuiviStockGC.Aucun.ToString(), (short)SuiviStockGC.Aucun));
                return listeItemSens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

  

