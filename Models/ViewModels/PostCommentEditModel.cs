using System.ComponentModel.DataAnnotations;

namespace Web2._6.Models.ViewModels
{
    public class PostCommentEditModel
    {
        [Required]
        public String Text { get; set; }
    }
}
