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
    public class DetailDimensionController : ControllerBase
    {
        IDetailDimensionService _DetailDimensionService;

        public DetailDimensionController(IDetailDimensionService DetailDimension)
        {
            _DetailDimensionService = DetailDimension;
        }
        [HttpGet("Get")]
        public List<DetailDimension> GetAll()
        {
            var res = _DetailDimensionService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Find/{id}")]
        public DetailDimension GetById(int id)
        {
            try
            {
                var res = _DetailDimensionService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        [HttpPost("Create")]
        public ActionResult<DetailDimension> Post([FromBody]DetailDimension DetailDimension)
        {

            var res = _DetailDimensionService.Add(DetailDimension);
            if (res is null)
                return BadRequest();
            else
                return DetailDimension;
        }
        [HttpPut("Edit")]
        public ActionResult<DetailDimension> Put([FromBody]DetailDimension DetailDimension)
        {
            var res = _DetailDimensionService.Update(DetailDimension);

            if (res is null)
                return BadRequest();
            else
                return DetailDimension;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;

           
                _DetailDimensionService.Delete(id);
                res = true;
            

            return res;

        }

        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {

            bool res = false;

            
                _DetailDimensionService.DeleteAdmin(id);
                res = true;
           

            return res;

        }
    }
}