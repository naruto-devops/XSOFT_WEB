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
    public class UniteController : ControllerBase
    {
        IUniteService _UniteService;

        public UniteController(IUniteService Unite)
        {
            _UniteService = Unite;
        }
        [HttpGet("Get")]
        public List<Unite> GetAll()
        {
            var res = _UniteService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Find/{id}")]
        public Unite GetById(int id)
        {
            try
            {
                var res = _UniteService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        [HttpPost("Create")]
        public ActionResult<Unite> Post([FromBody]Unite Unite)
        {

            var res = _UniteService.Add(Unite);
            if (res is null)
                return BadRequest();
            else
                return Unite;
        }
        [HttpPut("Edit")]
        public ActionResult<Unite> Put([FromBody]Unite Unite)
        {
            var res = _UniteService.Update(Unite);

            if (res is null)
                return BadRequest();
            else
                return Unite;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;

            //if (_UniteService.CheckUnite_ExistTiers(id) == null)
            //{

            //}
            _UniteService.Delete(id);
            res = true;
            return res;

        }

        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {

            bool res = false;

            //if (_UniteService.CheckUnite_ExistTiers(id) == null)
            //{
                _UniteService.DeleteAdmin(id);
                res = true;
            //}

            return res;

        }
    }
}