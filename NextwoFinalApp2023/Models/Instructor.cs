using NextwoFinalApp2023.Models.SharedProp;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NextwoFinalApp2023.Models
{
    public class Instructor : CommonProp
    {
        public int InstructorId { get; set; }
        [Display(Name = "Instructor Name")]
        [Required]
        public string? InstructorName { get; set; }
        [Display(Name = "Instructor Picture")]
        [Required]
        public string? InstructorImg { get; set; }
        [Required]
        public string? Position { get; set; }
        public string? FB { get; set; }
        public string? Tw { get; set; }
        public string? LinkedIn { get; set; }
    }
}
