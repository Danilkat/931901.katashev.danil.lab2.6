using System.ComponentModel.DataAnnotations;

namespace Web2._6.Models.ViewModels
{
    public class PostCategoryEditModel
    {
        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
