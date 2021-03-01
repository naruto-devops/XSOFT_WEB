using Models.Data;
using Models.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
   public class ClassificationArticleRepository : IClassificationArticleRepository
    {
        XSoftContext _context;

        public ClassificationArticleRepository(XSoftContext context)
        {
            _context = context;
        }


        public List<ClassificationArticle> GetAll()
        {
            var res = new List<ClassificationArticle>();
            try
            {
                res = _context.ClassificationArticles.Where(a => a.Deleted == false).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public ClassificationArticle GetById(int id)
        {
            try
            {
                var res = _context.ClassificationArticles.FirstOrDefault(r => r.ID.Equals(id));
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClassificationArticle Add(ClassificationArticle ClassificationArticle)
        {
            try
            {
                _context.ClassificationArticles.Add(ClassificationArticle);
                _context.SaveChanges();
                return ClassificationArticle;
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
                var res = _context.ClassificationArticles.FirstOrDefault(r => r.ID.Equals(id));
                res.Deleted = true;
                if (res != null)
                {
                    _context.ClassificationArticles.Update(res);
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
                var res = _context.ClassificationArticles.FirstOrDefault(r => r.ID.Equals(id));

                if (res != null)
                {
                    _context.ClassificationArticles.Remove(res);
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
        public ClassificationArticle Update(ClassificationArticle ClassificationArticle)
        {

            try
            {
                _context.Update(ClassificationArticle);
                _context.SaveChanges();
                return ClassificationArticle;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        
    }
}
