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
    public class Famille0Controller : ControllerBase
    {
        IFamille0Service _Famille0Service;
        IFamilleService _FamilleService;

        public Famille0Controller(IFamille0Service famille0, IFamilleService famille)
        {
            _Famille0Service = famille0;
            _FamilleService = famille;
        }
        [HttpGet("Get")]
        public List<Famille0> GetAll()
        {
            return _Famille0Service.GetAll();

        }
        [HttpGet("Find/{id}")]
        public Famille0 GetById(int id)
        {
            return _Famille0Service.GetById(id);

        }
        [HttpPost("Create")]
        public Famille0 Post([FromBody]Famille0 ft)
        {
            if (ModelState.IsValid)
                _Famille0Service.Add(ft);
            return ft;

        }
        [HttpPut("Edit")]
        public Famille0 Put([FromBody]Famille0 ft)
        {


            if (ModelState.IsValid)
                _Famille0Service.Update(ft);
            return ft;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res = false;

            if (_FamilleService.CheckFamille0_ExistFamille(id) == null)
            {
                _Famille0Service.Delete(id);
                res = true;

            }

            return res;

        }
    }
}