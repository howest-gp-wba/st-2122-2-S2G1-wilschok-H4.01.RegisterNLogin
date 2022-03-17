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
    }
}
