using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext db;

        public AccountController(DataContext db)
        {
            this.db = db;
        }

        [Route("account")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("account/register/form")]
        public IActionResult CreateAdminForm()
        {
            return PartialView(new User());
        }

        [HttpPost("account/register")]
        public IActionResult CreateAdmin()
        {
            var status = new Pair<string, string>("danger", "Could Not Reset Password.");
            return PartialView("_StatusAlert", status);
        }

        [Route("account/login/form")]
        public IActionResult LoginForm()
        {
            return PartialView();
        }

        [HttpPost("account/login")]
        public IActionResult Login()
        {
            var status = new Pair<string, string>("warning", "Could Not Reset Password.");
            return PartialView("_StatusAlert", status);
        }

        [Route("account/forgot/form")]
        public IActionResult ForgotForm()
        {
            return PartialView();
        }

        [HttpPost("account/forgot")]
        public IActionResult Forgot()
        {
            var status = new Pair<string, string>("info", "Could Not Reset Password.");
            return PartialView("_StatusAlert", status);
        }

        [Route("account/reset/form")]
        public IActionResult ResetForm()
        {
            return PartialView();
        }

        [HttpPost("account/reset")]
        public IActionResult Reset()
        {
            var status = new Pair<string, string>("danger", "Could Not Reset Password.");
            return PartialView("_StatusAlert", status);
        }
    }
}
