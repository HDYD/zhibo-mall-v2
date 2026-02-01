using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zhibo.Mall.API.Entities
{
    public class Livestream
    {
        [Key]
        public int Id { get; set; }

        public int HostId { get; set; } // UserId of the host
        
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(255)]
        public string CoverImage { get; set; } = string.Empty;

        [MaxLength(255)]
        public string StreamUrl { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Status { get; set; } = "Upcoming"; // Live, Ended, Upcoming

        public int ViewerCount { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
