using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseurController : Controller
    {
        IFournisseurService _fournisseurService;

        public FournisseurController(IFournisseurService Tiers)
        {
            _fournisseurService = Tiers;

        }
        [HttpGet("Get")]
        public List<Tiers> GetAll()
        {
            return _fournisseurService.GetAll();
        }

        [HttpGet("GetIncrementNum")]
        public JsonResult GetIncrement()
        {
            
            return Json(_fournisseurService.GetIncrement());
        }
        [HttpGet("GetContacts/{id}")]
        public List<Contact> GetContacts(int id)
        {
            return _fournisseurService.GetcontactByTiers(id);
        }

        [HttpGet("CheckExistNumeroFournisseur/{numero}")]
        public bool CheckExistNumeroFournisseur(string numero)
        {


            return _fournisseurService.CheckUnicCodification(numero);

        }

        [HttpGet("Find/{id}")]
        public Tiers GetById(int id)
        {

            return _fournisseurService.GetById(id);

        }
        [HttpPost("Create")]
        public Tiers Post([FromBody]Tiers Tiers)
        {
            if (ModelState.IsValid)
                _fournisseurService.Add(Tiers);
            return Tiers;


        }
        [HttpPut("Edit")]
        public Tiers Put([FromBody]Tiers Tiers)
        {


            if (ModelState.IsValid)
                _fournisseurService.Update(Tiers);
            return Tiers;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res = false;

            //if (_fournisseurService.CheckTiers_ExistDocLig(id) == false)
            //{

            _fournisseurService.Delete(id);
            res = true;

            //}

            return res;



        }
        
    }
}