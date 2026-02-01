using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zhibo.Mall.API.Data;
using Zhibo.Mall.API.Entities;

namespace Zhibo.Mall.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivestreamController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LivestreamController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Livestream>>> GetLivestreams([FromQuery] string status = "Live")
        {
            return await _context.Livestreams
                .Where(l => l.Status == status)
                .OrderByDescending(l => l.ViewerCount)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livestream>> GetLivestream(int id)
        {
            var stream = await _context.Livestreams.FindAsync(id);
            if (stream == null) return NotFound();
            return stream;
        }
    }
}
