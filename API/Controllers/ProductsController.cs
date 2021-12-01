using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using core.Entities;
using Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task< ActionResult <IEnumerable< Products>>> GetProducts()
        {
            var items = await _context.Products.ToListAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task< ActionResult<Products>> GetProduct(int id)
        {
            var item = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(item);
        }
    }
}