using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Roles.Find(1));
        }
    }
}
