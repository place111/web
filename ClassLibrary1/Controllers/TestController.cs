using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
    }
}
