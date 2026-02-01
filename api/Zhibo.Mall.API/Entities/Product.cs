using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zhibo.Mall.API.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        public int Stock { get; set; }

        [MaxLength(255)]
        public string CoverImage { get; set; } = string.Empty;

        public string ImagesJson { get; set; } = "[]"; // JSON array of image URLs

        public int CategoryId { get; set; }

        public bool IsSeckill { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
