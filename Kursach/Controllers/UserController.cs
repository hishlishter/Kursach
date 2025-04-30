using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Kursach.Models;

namespace Kursach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Context _context;
        public UsersController(Context context)
        {
            _context = context;
            if (!_context.User.Any())
            {
                _context.User.Add(new User
                {
                    Login = "https://blogs.microsoft.com/",
                    Password = "dddd",
                    FIO = "Ivanov Ivan Ivanich",
                    Status = "Buyer"
                }) ;
                _context.SaveChanges();
            }
        }
        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }
        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var blog = await _context.User.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return blog;
        }

        // POST: api/Blogs
        [HttpPost]
        public async Task<ActionResult<User>> PostBlog(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBlog", new { id = user.IdUser }, User);
        }

    }
}
