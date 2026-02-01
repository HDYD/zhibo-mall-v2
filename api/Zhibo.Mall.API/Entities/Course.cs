using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zhibo.Mall.API.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int InstructorId { get; set; } // UserId

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [MaxLength(255)]
        public string CoverImage { get; set; } = string.Empty;

        [MaxLength(255)]
        public string VideoUrl { get; set; } = string.Empty;

        public int DurationMinutes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
