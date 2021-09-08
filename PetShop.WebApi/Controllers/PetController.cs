using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetShop.Core.IServices;
using PetShop.Core.Models;

namespace PetShop.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public ActionResult<List<Pet>> ReadAll()
        {
            return _petService.ReadAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Pet> GetById(int id)
        {
            return _petService.GetById(id) == null
                ? BadRequest("There is no pet with that id")
                : Ok(_petService.GetById(id));
        }

        [HttpGet]
        public ActionResult<Pet> Create([FromBody] Pet pet)
        {
            if (pet.Id != null)
            {
                return BadRequest("There is no id");
            }

            return Created("pet was created", _petService.Create(pet));
        }
        
        [HttpPut("{id}")]
        public ActionResult<Pet> Update(int id, [FromBody] Pet pet)
        {
            if (id != pet.Id)
                return BadRequest("parameter id and pet id must be the same");
            return Ok(_petService.Update(pet));
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            return _petService.Delete(id) ? Ok("pet was deleted") : StatusCode(404,
                "did not find a pet with that id");
        } 
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}