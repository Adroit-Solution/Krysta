using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_Series.Models;
using Test_Series.Repository;

namespace Test_Series.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticationRepository repository;

        public AccountController(IAuthenticationRepository repository)
        {
            this.repository = repository;
        }
        
        // GET: AccountController
        public ActionResult SignUpIndex()
        {
            return View();
        }


        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpIndex(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = repository.SignUp(model);
                if (result.Result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }   
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if(ModelState.IsValid)
            {
                var result = repository.SignIn(loginModel);
                if (result.Result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login");
                    return View(loginModel);
                }
            }
            else
            {
                return View(loginModel);
            }
        }

        public ActionResult Logout()
        {
            repository.Logout();
            return RedirectToAction("Index", "Home");
        }

        // GET: AccountController/Details/5
        public ActionResult Profile(int id)
        {
            return View();
        }


        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
