using System.ComponentModel.DataAnnotations;

namespace Web2._6.Models
{
    public class PostCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
