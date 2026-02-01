using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zhibo.Mall.API.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; } = DateTime.Now;

        [MaxLength(50)]
        public string Author { get; set; } = string.Empty;
    }
}
