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
    public class ClassificationArticleController : ControllerBase
    {
        IClassificationArticleService _ClassificationArticleService;

        public ClassificationArticleController(IClassificationArticleService ClassificationArticle)
        {
            _ClassificationArticleService = ClassificationArticle;
        }
        [HttpGet("Get")]
        public List<ClassificationArticle> GetAll()
        {
            var res = _ClassificationArticleService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Find/{id}")]
        public ClassificationArticle GetById(int id)
        {
            try
            {
                var res = _ClassificationArticleService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        [HttpPost("Create")]
        public ActionResult<ClassificationArticle> Post([FromBody]ClassificationArticle ClassificationArticle)
        {

            var res = _ClassificationArticleService.Add(ClassificationArticle);
            if (res is null)
                return BadRequest();
            else
                return ClassificationArticle;
        }
        [HttpPut("Edit")]
        public ActionResult<ClassificationArticle> Put([FromBody]ClassificationArticle ClassificationArticle)
        {
            var res = _ClassificationArticleService.Update(ClassificationArticle);

            if (res is null)
                return BadRequest();
            else
                return ClassificationArticle;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;
                if( _ClassificationArticleService.Delete(id))
                res = true;
            

            return res;

        }

        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {

            bool res = false;
              if (_ClassificationArticleService.DeleteAdmin(id))
              res = true;
           
            return res;

        }
    }
}