using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TizzarthApi.Models;
using TizzarthApi.Services;

namespace TizzarthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzeriasController : ControllerBase
    {
        private readonly PizzeriaService _PizzeriaService;

        public PizzeriasController(PizzeriaService PizzeriaService)
        {
            _PizzeriaService = PizzeriaService;
        }

        [HttpGet]
        public ActionResult<List<Pizzeria>> Get() =>
            _PizzeriaService.Get();

        [HttpGet("{id:length(24)}", Name = "GetPizzeria")]
        public ActionResult<Pizzeria> Get(string id)
        {
            var emp = _PizzeriaService.Get(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }

    }
}
