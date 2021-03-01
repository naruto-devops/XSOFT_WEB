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
    public class DimensionController : ControllerBase
    {
        IDimensionService _DimensionService;

        public DimensionController(IDimensionService Dimension)
        {
            _DimensionService = Dimension;
        }
        [HttpGet("Get")]
        public List<Dimension> GetAll()
        {
            var res = _DimensionService.GetAll();
            if (res is null)
                return null;
            else
                return res;

        }
        [HttpGet("Find/{id}")]
        public Dimension GetById(int id)
        {
            try
            {
                var res = _DimensionService.GetById(id);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        [HttpPost("Create")]
        public ActionResult<Dimension> Post([FromBody]Dimension Dimension)
        {

            var res = _DimensionService.Add(Dimension);
            if (res is null)
                return BadRequest();
            else
                return Dimension;
        }
        [HttpPut("Edit")]
        public ActionResult<Dimension> Put([FromBody]Dimension Dimension)
        {
            var res = _DimensionService.Update(Dimension);

            if (res is null)
                return BadRequest();
            else
                return Dimension;
        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {

            bool res = false;

            if (_DimensionService.CheckDimension_ExistDetailDimension(id) == null)
            {
                _DimensionService.Delete(id);
                res = true;
            }

            return res;

        }

        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {

            bool res = false;

            if (_DimensionService.CheckDimension_ExistDetailDimension(id) == null)
            {
                _DimensionService.DeleteAdmin(id);
                res = true;
            }

            return res;

        }
    }
}