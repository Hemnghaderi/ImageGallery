using ImageGallery.Models.Forms;
using ImageGallery.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class AuthenticatorController : Controller
    {
        private readonly AccountService _accountService;

        public AuthenticatorController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (await _accountService.CheckIfUserExists(model.Email))
            {
                ViewData["UserAlreadyExists"] = "A user with the same Email address already exists";
                return View(model);
            }

            if (await _accountService.RegisterAsync(model))
                return RedirectToAction("Login");
                

            return View(model);
    
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (await _accountService.LoginAsync(model))
                return RedirectToAction("Index", "Home");

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
