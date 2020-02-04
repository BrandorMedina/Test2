using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test1.Areas.Identity.Pages.Account;

namespace Test1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult RedirectResult()
        {
            return Redirect("/Identity/Account/Login");
        }
    }
}