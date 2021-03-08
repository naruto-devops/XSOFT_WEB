using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
   public  class ClassificationArticleServices : IClassificationArticleService
    {
        IClassificationArticleRepository _ClassificationArticleRepository;

        public ClassificationArticleServices(IClassificationArticleRepository dvs)
        {
            _ClassificationArticleRepository = dvs;
        }

        public List<ClassificationArticle> GetAll()
        {
            List<ClassificationArticle> result = new List<ClassificationArticle>();
            try
            {
                result = _ClassificationArticleRepository.GetAll();
                return result;
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
                var res = _ClassificationArticleRepository.GetById(id);
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
                _ClassificationArticleRepository.Add(ClassificationArticle);
                return ClassificationArticle;
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
                _ClassificationArticleRepository.Update(ClassificationArticle);
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
                return _ClassificationArticleRepository.Delete(id);
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
                return _ClassificationArticleRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



      
    }
}
