using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Models.Forms
{
    public class RegisterFormModel
    {
        [Required]
        [StringLength(40, ErrorMessage = "To many characters have been used")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(40, ErrorMessage = "To many characters have been used")]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(60, ErrorMessage = "The Address you've typed in is not correct")]
        [Display(Name = "Address:")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(16, ErrorMessage = "To long Postal Code", MinimumLength = 3)]
        [Display(Name = "Postal Code:")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [StringLength(40, ErrorMessage = "Please give the correct value")]
        [Display(Name = "City:")]
        public string City { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Invalid E-Mail Address, if further issues, please send us an E-Mail")]
        [Display(Name = "E-Mail Address:")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "Maximum value for Password is 30 characters")]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "Type in correct value as Password")]
        public string ConfirmPassword { get; set;} = string.Empty;

    }
}
