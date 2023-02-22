using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Models.Forms
{
    public class LoginFormModel
    {
        [Required]
        [Display(Name = "E-Mail Address:")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Remember Me:")]
        public bool RememberMe { get; set; } = false;

    }
}
