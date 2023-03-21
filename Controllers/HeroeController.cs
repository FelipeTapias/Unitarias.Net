using ASPTEst.Models;
using ASPTEst.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPTEst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HeroeController : ControllerBase
    {
        private readonly IHeroeService _heroeService;

        public HeroeController(IHeroeService service)
        {
            _heroeService = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_heroeService.Get());

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            var heroe = _heroeService.Get(Id);

            if (heroe == null)
                return NotFound();

            return Ok(heroe);

        }
    }
}
