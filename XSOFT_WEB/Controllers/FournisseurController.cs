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
    public class FournisseurController : ControllerBase
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


        [HttpGet("GetContacts/{id}")]
        public List<Contact> GetContacts(int id)
        {
            return _fournisseurService.GetcontactByTiers(id);
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
        [HttpDelete("CheckExistNumeroFournisseur")]
        public bool CheckExistNumeroTiers(string numero)
        {


            return _fournisseurService.CheckUnicCodification(numero);

        }
    }
}