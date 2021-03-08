using Models.Models;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
   public interface IArticleGeneriqueService
    {
        List<ArticleGenerique> GetAll();
        ArticleGenerique GetById(int id);
        ArticleGenerique Add(ArticleGenerique cbl);
        ArticleGenerique Update(ArticleGenerique cbl);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        bool CheckUnicReference(string reference);
        List<EnumToList> GetTypes();
        List<EnumToList> GetStatus();
        List<EnumToList> GetSuiviStock();
    }
}
