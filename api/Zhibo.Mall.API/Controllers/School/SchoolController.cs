using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zhibo.Mall.API.Data;
using Zhibo.Mall.API.Entities;

namespace Zhibo.Mall.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("articles")]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticles()
        {
            return await _context.Articles.OrderByDescending(a => a.PublishDate).ToListAsync();
        }

        [HttpGet("articles/{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null) return NotFound();
            return article;
        }
    }
}
