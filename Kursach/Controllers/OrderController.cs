using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kursach.Models;

namespace Kursach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Context _context;
        public OrderController(Context context)
        {
            _context = context;
            if (!_context.Order.Any())
            {
                _context.Order.Add(new Order
                {
                    //IdOrder = "https://blogs.microsoft.com/"
                });
                _context.SaveChanges();
            }
        }
        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetUser()
        {
            return await _context.Order.ToListAsync();
        }
        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetUser(int id)
        {
            var blog = await _context.Order.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return blog;
        }
    }
}
