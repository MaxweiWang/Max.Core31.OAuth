using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Max.Core3_1.Auth2Demo.Controllers
{
    public class JWTController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            foreach (var item in base.HttpContext.User.Identities.First().Claims)
            {
                Console.WriteLine($"{item.Type}:{item.Value}");
            }
            return View();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult IndexRole()
        {
            return View();
        }


        [Authorize(Policy = "AdminPolicy")]
        public IActionResult IndexPolicy()
        {
            return View();
        }

        [Authorize(Policy = "DoubleEmail")]
        public IActionResult IndexPolicyDouble()
        {
            return View();
        }
    }
}