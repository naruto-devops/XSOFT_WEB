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
    public class ArticleGeneriqueController : Controller
    {
        IArticleGeneriqueService _ArticleGeneriqueService;

        public ArticleGeneriqueController(IArticleGeneriqueService articleGenerique)
        {
            _ArticleGeneriqueService = articleGenerique;
        }
        [HttpGet("Get")]
        public List<ArticleGenerique> GetAll()
        {
            return _ArticleGeneriqueService.GetAll();

        }
        [HttpGet("CheckUnicReference")]
        public bool CheckUnicReference(string reference)
        {
            return _ArticleGeneriqueService.CheckUnicReference(reference);

        }
        [HttpGet("GetTypeUser")]
        public IActionResult GetTypeArticle()
        {
            return Json(_ArticleGeneriqueService.GetTypes());
        }
        [HttpGet("GetSuiviStock")]
        public IActionResult GetSuiviStocks()
        {
            return Json(_ArticleGeneriqueService.GetSuiviStock());
        }
        [HttpGet("GetStatusArticle")]
        public IActionResult GetStatusArticle()
        {
            return Json(_ArticleGeneriqueService.GetStatus());
        }

        [HttpGet("Find/{id}")]
        public ArticleGenerique GetById(int id)
        {
            return _ArticleGeneriqueService.GetById(id);

        }

        [HttpPost("Create")]
        public ArticleGenerique Post([FromBody]ArticleGenerique articleGenerique)
        {

            return _ArticleGeneriqueService.Add(articleGenerique);

        }
        [HttpPut("Edit")]
        public ArticleGenerique Put([FromBody]ArticleGenerique articleGenerique)
        {

            _ArticleGeneriqueService.Update(articleGenerique);
            return articleGenerique;

        }
        //[HttpDelete("Delete/{id}")]
        //public bool Delete(int id)
        //{
        //    bool res;
        //    var result = _ArticleGeneriqueService.Delete(id) ? res = true : res = false;
        //    return res;


        //}
      //  [HttpDelete("DeleteAdmin/{id}")]
        //public bool DeleteAdmin(int id)
        //{
        //    bool res;
        //    var result = _ArticleGeneriqueService.DeleteAdmin(id) ? res = true : res = false;

        //    return res;

        //}

    }
}