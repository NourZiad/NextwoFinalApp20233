using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Models.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Enter Email")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Password")]
        public string? Password { get; set; }
    }
}
