using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevXuongMoc.Models
{
    public class Customer
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        [StringLength(10)]
        public string? Phone { get; set; }

        [StringLength(100)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? Avatar { get; set; }

        public string? Birthday { get; set; }

        [Required]
        [StringLength(10)]
        public string? Gender { get; set; }

        [Required]
        [StringLength(10)]
        public string? Password { get; set; }

        [StringLength(100)]
        public string? Facebook { get; set; }
    }
}
