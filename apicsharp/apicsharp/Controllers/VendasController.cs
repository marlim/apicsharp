using Microsoft.AspNetCore.Mvc;
using apicsharp.Data;
using apicsharp.Models;

namespace apicsharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly AppDbContext _context;


        public VendasController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Vendas.ToList());


        [HttpPost]
        public IActionResult Create(Venda venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = venda.Id }, venda);
        }
    }
}
