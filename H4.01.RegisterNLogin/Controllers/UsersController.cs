using H4._01.RegisterNLogin.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H4._01.RegisterNLogin.Controllers
{
    public class UsersController : Controller
    {
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
        public IActionResult Register([FromForm] UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(RegisterSuccess));
            }

            return View(userRegisterViewModel);
        }

        public IActionResult RegisterSuccess()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([FromForm]UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                // kortsluiten voor 1 hardgecodeerde gebruiker
                // normaal gezien hier controle van de data in bv een database
                string validEmail = "bert@howest.be";
                string validPassword = "testtest";

                if(userLoginViewModel.Email.ToLower() == validEmail.ToLower() &&
                    userLoginViewModel.Password == validPassword)
                {
                    return RedirectToAction(nameof(LoginSuccess));
                } else
                {
                    ModelState.AddModelError("", "You entered invalid credentials");
                }
            }
            return View(userLoginViewModel);
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }
    }
}
