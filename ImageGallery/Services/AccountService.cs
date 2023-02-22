using ImageGallery.Models.Forms;
using ImageGallery.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace ImageGallery.Services
{
    public class AccountService
    {
        private readonly SignInManager<GalleryUser> _signInManager;
        private readonly UserManager<GalleryUser> _userManager;

        public AccountService(SignInManager<GalleryUser> signInManager, UserManager<GalleryUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> RegisterAsync(RegisterFormModel model)
        {
            var user = new GalleryUser()
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                PostalCode = model.PostalCode,
                City = model.City,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
                return true;

            return false;
        }

        public async Task<bool> LoginAsync(LoginFormModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, false);
            if (result.Succeeded)
                return true;
            return false;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> CheckIfUserExists(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
                return true;
            return false;
        }
    }
}
