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
    public class DashboardController : Controller
    {
        private readonly DataContext db;

        public DashboardController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Roles.Find(new Random().Next(1, 4)));
        }
    }
}
