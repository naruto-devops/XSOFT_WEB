using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Implementations.TagRepository;

namespace Services.Implementations
{
  public  class TagServices : ITagService
    {

        ITagRepository _TagRepository;

        public TagServices(ITagRepository tag)
        {
            _TagRepository = tag;
        }

        public List<Menu> GetMenus()
        {
            List<Menu> result = new List<Menu>();
            try
            {
                result = _TagRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
