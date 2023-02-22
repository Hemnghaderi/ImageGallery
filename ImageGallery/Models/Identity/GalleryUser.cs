using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Models.Identity
{
    public class GalleryUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [PersonalData]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [PersonalData]
        [Required]
        public string Address { get; set; } = string.Empty;

        [PersonalData]
        [Required]
        public string PostalCode { get; set; } = string.Empty;

        [PersonalData]
        [Required]
        public string City { get; set; } = string.Empty;
    }
}
