using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kursach.Models;

namespace Kursach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly Context _context;
        public BasketController(Context context)
        {
            _context = context;
            if (!_context.Basket.Any())
            {
                _context.Basket.Add(new Basket
                {
                    //IdOrder = "https://blogs.microsoft.com/"
                });
                _context.SaveChanges();
            }
        }
        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Basket>>> GetUser()
        {
            return await _context.Basket.ToListAsync();
        }
        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Basket>> GetUser(int id)
        {
            var blog = await _context.Basket.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return blog;
        }
    }
}
