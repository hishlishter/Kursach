using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kursach.Models;

namespace Kursach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;
        public ProductController(Context context)
        {
            _context = context;
            if (!_context.Product.Any())
            {
                _context.Product.Add(new Product
                {
                    ProductName = "https://blogs.microsoft.com/"
                });
                _context.SaveChanges();
            }
        }
        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetUser()
        {
            return await _context.Product.ToListAsync();
        }
        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetUser(int id)
        {
            var blog = await _context.Product.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return blog;
        }
    }
}
