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
    public class UtilisateurController : Controller
    {
        IUtilisateurService _UtilisateurService;

        public UtilisateurController(IUtilisateurService mdt)
        {
            _UtilisateurService = mdt;
        }
        [HttpGet("Get")]
        public List<Utilisateur> GetAll()
        {
            return _UtilisateurService.GetAll();

        }

        [HttpGet("GetTypeUser")]
        public IActionResult GetTypeUser()
        {
            return Json(_UtilisateurService.GetTypeUsers());
        }
        [HttpGet("Find/{id}")]
        public Utilisateur GetById(int id)
        {
            return _UtilisateurService.GetById(id);

        }

        [HttpGet("CheckExistUser/{login}/{password}")]
        public IActionResult CheckExistUser(string login,string password)
        {
            Utilisateur result = new Utilisateur();

           
            if ((result = _UtilisateurService.CheckExistUser(login, password))!= null)
            {
                result.Date_connexion = DateTime.Now;
                _UtilisateurService.Update(result);


                return Json(result); }
                
            else
                return NotFound();
         
           

        }
        [HttpPost("Create")]
        public Utilisateur Post([FromBody]Utilisateur utilisateur)
        {
            _UtilisateurService.Add(utilisateur);
            return utilisateur;

        }
        [HttpPut("Edit")]
        public Utilisateur Put([FromBody]Utilisateur utilisateur)
        {

             _UtilisateurService.Update(utilisateur);
            return utilisateur;

        }
        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            bool res;
            var result= _UtilisateurService.Delete(id) ? res= true : res= false;
            return res;
           

        }
        [HttpDelete("DeleteAdmin/{id}")]
        public bool DeleteAdmin(int id)
        {
            bool res;
            var result = _UtilisateurService.DeleteAdmin(id) ? res = true : res = false;
            
            return res;

        }
    }
}