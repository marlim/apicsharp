using Microsoft.AspNetCore.Mvc;
using apicsharp.Data;
using apicsharp.Models;

namespace apicsharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;


        public ClientesController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Clientes.ToList());


        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = cliente.Id }, cliente);
        }
    }
}
