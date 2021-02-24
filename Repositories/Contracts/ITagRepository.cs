using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Implementations.TagRepository;

namespace Repositories.Contracts
{
   public  interface ITagRepository
    {
         List<Menu> GetAll();

    }
}
