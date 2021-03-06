﻿using Models.Models;
using Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IArticleGeneriqueRepository
    {
        List<ArticleGenerique> GetAll();
        ArticleGenerique GetById(int id);
        
        ArticleGenerique Add(ArticleGenerique ArticleGenerique);
        ArticleGenerique Update(ArticleGenerique ArticleGenerique);
        bool Delete(int id);
        bool DeleteAdmin(int id);
        bool CheckUnicReference(string reference);
        List<EnumToList> GetTypes();
        List<EnumToList> GetStatus();
        List<EnumToList> GetSuiviStock();
    }
}
