using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RhodesShoppe.Api.Models;

namespace RhodesShoppe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairsController : ControllerBase
    {
        private readonly ShopContext _context;

        public RepairsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        // GET: api/repairs
        public async Task<ActionResult<IEnumerable<GuitarRepair>>> GetRepairs()
        {
            return await _context.GuitarRepairs.ToListAsync();
        }
    }

}
