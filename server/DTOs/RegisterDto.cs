using System.ComponentModel.DataAnnotations;

namespace server.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(16, ErrorMessage = "Maximum length 16 charactor at least 4.", MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        public string ConfirmPassword { get; set; }
    }
}