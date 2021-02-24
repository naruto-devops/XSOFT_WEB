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
    public class FamilleController : ControllerBase
    {
        IFamilleService _FamilleService;

        public FamilleController(IFamilleService fts)
        {
            _FamilleService = fts;
        }
        [HttpGet("Get")]
        public List<Famille> GetAll()
        {
            return _FamilleService.GetAll();

        }
        [HttpGet("Find/{id}")]
        public Famille GetById(int id)
        {
            return _FamilleService.GetById(id);

        }
        [HttpPost("Create")]
        public Famille Post([FromBody]Famille ft)
        {
            if (ModelState.IsValid)
                _FamilleService.Add(ft);
            return ft;

        }
        [HttpPut("Edit")]
        public Famille Put([FromBody]Famille ft)
        {


            if (ModelState.IsValid)
                _FamilleService.Update(ft);
            return ft;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res = false;

            //if (_FamilleService.CheckFamille0_ExistArticle(id) == null)
            //{
                _FamilleService.Delete(id);
                res = true;

            //}

            return res;

        }
        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteADmin(int id)
        {
            bool res = false;

            //if (_FamilleService.CheckFamille0_ExistArticle(id) == null)
            //{
            _FamilleService.DeleteAdmin(id);
            res = true;

            //}

            return res;

        }

    }
}