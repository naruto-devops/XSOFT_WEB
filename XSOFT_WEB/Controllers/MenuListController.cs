using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuListController : ControllerBase
    {
        ITagService _ITagService;

        public MenuListController(ITagService tagService)
        {
            _ITagService = tagService;
        }
        [HttpGet]
        public List<Menu> GetAll()
        {
            return _ITagService.GetMenus();

        }
    }
}