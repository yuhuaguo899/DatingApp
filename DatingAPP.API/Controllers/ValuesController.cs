using System.Linq;
using DatingAPP.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingAPP.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            var values=_context.Values.ToList();

            return Ok(values);
        }


         [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var values=_context.Values.FirstOrDefault(x=>x.Id==id);

            return Ok(values);
        }


    }
}
    
