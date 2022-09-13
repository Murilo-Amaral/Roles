using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]   
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação não são iguais.")]
        public string ConfirmPassword { get; set; }

        public string? ReturnUrl { get; set; }

    }
}
