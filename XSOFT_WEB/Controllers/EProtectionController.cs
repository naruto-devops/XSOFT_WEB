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
    public class EProtectionController : ControllerBase
    {
        IEProtectionService _eprotectionService;

        public EProtectionController(IEProtectionService eprotection)
        {
            _eprotectionService = eprotection;
        }
       
        [HttpGet("FindByUser/{id}")]
        public List<EProtection> GetByUser(int id)
        {
        
                var res = _eprotectionService.GetByUser(id);
            if (res is null)
                return null;
            else
                return res;
        
        }
        [HttpPost("Add")]
        public ActionResult<EProtection> Post([FromBody]EProtection eprotection)
        {

            var res = _eprotectionService.Add(eprotection);
            if (res is null)
                return BadRequest();
            else
                return eprotection;
        }
    
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            
             return   _eprotectionService.Delete(id);
             

        }
    }
}