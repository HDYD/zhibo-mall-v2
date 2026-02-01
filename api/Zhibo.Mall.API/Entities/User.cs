using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zhibo.Mall.API.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Nickname { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Avatar { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        public int Points { get; set; }

        public int Level { get; set; } // 0: Normal, 1: VIP, etc.

        public bool IsAgent { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
