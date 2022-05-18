using System.ComponentModel.DataAnnotations;

namespace Web2._6.Models
{
    public class ForumCategory
    {
        [Required]
        public String Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();

        public ICollection<Forum> Forums { get; set; }
    }
}
