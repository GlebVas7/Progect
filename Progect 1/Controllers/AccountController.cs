using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;
using Progect_1.Storage.Entity.AuthorizeView;
using System.Security.Claims;

namespace Progect_1.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IPersonModel _userManager;
        public AccountController(IPersonModel userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            Person user = await _userManager.FindUserByNamePasswordAsync(model.Name, model.Password);
            if (user != null)
            {
                await Authenticate(model.Name); //Аутентификация


                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Incorrect username or password.");
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Person user = await _userManager.FindUserByNameAsync(model.Name);
                if (user == null)
                {
                     //У нас Id не int, поэтому нужно его генерить ручками



                    //Добавляем пользователя в бд
                    await _userManager.AddUserToDataBase(model.Name,  model.Password, model.Lastname, model.NumberOfPhone);
                 

                    await Authenticate(model.Name); //Аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "This user already exists!");
            }
            return View(model);
        }

        [AllowAnonymous]
        

        //Сейчас будет куча непонятных штук (обратим внимание на то, что он private)
        private async Task Authenticate(string userName)
        {
            //Создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            //Создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            //Установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
