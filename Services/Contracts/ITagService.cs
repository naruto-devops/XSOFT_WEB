using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Implementations.TagRepository;

namespace Services.Contracts
{
    public interface ITagService
    {

        List<Menu> GetMenus();
    }
}
