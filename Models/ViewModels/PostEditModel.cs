using System.ComponentModel.DataAnnotations;

namespace Web2._6.Models.ViewModels
{
    public class PostEditModel
    {
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public String Title { get; set; }

        [Required]
        public String Text { get; set; }
    }
}
