using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.AdminApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            return View();
        }
    }
}
