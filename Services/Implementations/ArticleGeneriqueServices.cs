using Models.Models;
using Repositories.Contracts;
using Repositories.Implementations;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
  public   class ArticleGeneriqueServices : IArticleGeneriqueService
    {
        IArticleGeneriqueRepository _ArticleGeneriqueRepository;
        IParametresRepository _parametresRepository;
        IFamilleRepository _familleRepository;
        public ArticleGeneriqueServices(IArticleGeneriqueRepository articleGenerique, IParametresRepository  parametresRepository, IFamilleRepository familleRepository)
        {
            _ArticleGeneriqueRepository = articleGenerique;
            _parametresRepository = parametresRepository;
            _familleRepository = familleRepository;
        }

        public List<ArticleGenerique> GetAll()
        {
            List<ArticleGenerique> result = new List<ArticleGenerique>();
            try
            {
                result = _ArticleGeneriqueRepository.GetAll();
                return result;
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
                var res = _ArticleGeneriqueRepository.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ArticleGenerique Add(ArticleGenerique articleGenerique)
        {
            ArticleGenerique result = new ArticleGenerique();
            Parametres parametres = new Parametres();

            parametres = _parametresRepository.GetAll();

            if (parametres.INCART == false)
            {
                var res = CheckUnicReference(articleGenerique.Reference);
                if (res == false)
                   result = _ArticleGeneriqueRepository.Add(articleGenerique);
                else
                   result= null;
            }

            else
            { if (parametres.INCARTFAM == false)
                {
                    articleGenerique.Reference = parametres.NUMART;
                    while (CheckUnicReference(articleGenerique.Reference))
                    {
                        articleGenerique.Reference.IncrementCode();
                        
                    }
                    _ArticleGeneriqueRepository.Add(articleGenerique);
                    parametres.NUMART = articleGenerique.Reference;
                    _parametresRepository.Update(parametres);
                   

                }
                else
                {
                    Famille res = new Famille();
                    res= _familleRepository.GetById(articleGenerique.Familles.ID);
                    string s = articleGenerique.Familles.CodeFamille.Substring(0, 3);
                    articleGenerique.Reference = articleGenerique.Familles.CodeFamille.Substring(0, 3) + parametres.NUMART;

                    while (CheckUnicReference(articleGenerique.Reference))
                    {
                        articleGenerique.Reference.IncrementCode();

                    }
                   
                   result = _ArticleGeneriqueRepository.Add(articleGenerique);
                    parametres.NUMART = articleGenerique.Reference;
                    _parametresRepository.Update(parametres);



                }

            }

            return result;
           

        }

        public ArticleGenerique Update(ArticleGenerique articleGenerique)
        {
            try
            {
                _ArticleGeneriqueRepository.Update(articleGenerique);
                return articleGenerique;
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
                return _ArticleGeneriqueRepository.Delete(id);
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
                return _ArticleGeneriqueRepository.DeleteAdmin(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        
       
       
        public List<EnumToList> GetTypes()
        {
            List<EnumToList> result = new List<EnumToList>();
            try
            {
                result = _ArticleGeneriqueRepository.GetTypes();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<EnumToList> GetStatus()
        {
            List<EnumToList> result = new List<EnumToList>();
            try
            {
                result = _ArticleGeneriqueRepository.GetStatus();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckUnicReference(string reference)
        {
            bool res;
            try
            {
              res =  _ArticleGeneriqueRepository.CheckUnicReference(reference);
             
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return res;

        }
        public List<EnumToList> GetSuiviStock()
        {
            List<EnumToList> result = new List<EnumToList>();
            try
            {
                result = _ArticleGeneriqueRepository.GetSuiviStock();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
