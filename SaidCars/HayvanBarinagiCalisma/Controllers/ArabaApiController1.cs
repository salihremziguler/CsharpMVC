using HayvanBarinagiCalisma.Data;
using HayvanBarinagiCalisma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaApiController1 : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
       
        public ArabaApiController1(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<List<Araba>>> Get()
        {
            var y = await _context.Araba.Where(x=>x.Model>2010).ToListAsync();

           
            if (y is null)
            {
                return NoContent();
            }
            return y;

        }

        


    }
}
