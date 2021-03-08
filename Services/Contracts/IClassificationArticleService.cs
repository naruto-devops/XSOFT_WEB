using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public  interface IClassificationArticleService
    {
        List<ClassificationArticle> GetAll();
        ClassificationArticle GetById(int id);

        ClassificationArticle Add(ClassificationArticle ClassificationArticle);
        ClassificationArticle Update(ClassificationArticle ClassificationArticle);
        bool Delete(int id);
        bool DeleteAdmin(int id);
    }
}
