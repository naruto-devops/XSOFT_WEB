using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace XSOFT_WEB.Controllers
{
    [Route("api/[controller]")]
   // [EnableCors("AllowOrigin")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        IClientService _clientService;
     
        public ClientsController(IClientService Tiers)
        {
            _clientService = Tiers;
          
        }
        [HttpGet("Get")]
        public List<Tiers> GetAll()
        {
          return _clientService.GetAll();
        }

       
        [HttpGet("GetContacts/{id}")]
        public List<Contact> GetContacts(int id )
        {
            return _clientService.GetcontactByTiers(id);
        }

      

        [HttpGet("Find/{id}")]
        public Tiers GetById(int id)
        {
            
            return _clientService.GetById(id);

        }
        [HttpPost("Create")]
        public Tiers Post([FromBody]Tiers Tiers)
        {
            if (ModelState.IsValid)
                _clientService.Add(Tiers);
            return Tiers;
           

        }
        [HttpPut("Edit")]
        public Tiers Put( [FromBody]Tiers Tiers)
        {


            if (ModelState.IsValid)
                _clientService.Update(Tiers);
            return Tiers;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res = false;

            //if (_clientService.CheckTiers_ExistDocLig(id) == false)
            //{
            
                _clientService.Delete(id);
                res = true;

            //}

            return res;
            
           

        }
        [HttpDelete("CheckExistNumeroClient")]
        public bool CheckExistNumeroTiers(string numero)
        {


            return _clientService.CheckUnicCodification(numero);

        }
    }
}