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

        [Route("account/create/admin/form")]
        public IActionResult CreateAdminForm()
        {
            return PartialView(new User());
        }

        [Route("account/create/admin")]
        public IActionResult CreateAdmin([FromBody] User user)
        {
            System.Diagnostics.Debug.WriteLine(user.Firstname);
            return PartialView();
        }

        [Route("account/login/form")]
        public IActionResult LoginForm()
        {
            return PartialView();
        }

        [Route("account/login")]
        public IActionResult Login([FromBody] Pair<string, string> credentials)
        {
            return PartialView();
        }

        [Route("account/forgot/form")]
        public IActionResult ForgotPasswordForm()
        {
            return PartialView();
        }

        [Route("account/forgot")]
        public IActionResult Forgot([FromBody] Pair<string, string> credentials)
        {
            return PartialView();
        }

        [Route("account/reset/form")]
        public IActionResult ResetPasswordForm()
        {
            return PartialView();
        }

        [Route("account/reset")]
        public IActionResult ResetPassword([FromBody] Pair<string, string> credentials)
        {
            return PartialView();
        }
    }
}
