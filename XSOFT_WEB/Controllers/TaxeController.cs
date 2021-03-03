using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Repositories.Implementations;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxeController : Controller
    {
        ITaxeService _TaxeService;

        public TaxeController(ITaxeService Taxe)
        {
            _TaxeService = Taxe;
        }
        [HttpGet("Get")]
        public List<Taxe> GetAll()
        {
            var res = _TaxeService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Get/Sens")]
        public IActionResult GetSens()
        {
            var liste = _TaxeService.GetSens();
            return Json(liste);
        }
        [HttpGet("Get/TTaux")]
        public IActionResult GetTaux()
        {
            var liste = _TaxeService.GetTaux();
            return Json(liste);
        }
        [HttpGet("Get/TypeTaxe")]
        public IActionResult GetTypeTaxe()
        {
            var liste = _TaxeService.GetTypeTaxe();
            return Json(liste);
        }




        [HttpGet("Find/{id}")]
        public Taxe GetById(int id)
        {
            try
            {
                var res = _TaxeService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        [HttpPost("Create")]
        public ActionResult<Taxe> Post([FromBody]Taxe Taxe)
        {

            var res = _TaxeService.Add(Taxe);
            if (res is null)
                return BadRequest();
            else
                return Taxe;
        }
        [HttpPut("Edit")]
        public ActionResult<Taxe> Put([FromBody]Taxe Taxe)
        {
            var res = _TaxeService.Update(Taxe);

            if (res is null)
                return BadRequest();
            else
                return Taxe;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;

            if (_TaxeService.CheckTaxe_ExistFamille(id) == null)
            {
                _TaxeService.Delete(id);
                res = true;
            }

            return res;

        }

        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {

            bool res = false;

            if (_TaxeService.CheckTaxe_ExistFamille(id) == null)
            {
                _TaxeService.DeleteAdmin(id);
                res = true;
            }

            return res;

        }
    }
}