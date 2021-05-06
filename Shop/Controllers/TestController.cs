using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace Shop.Controllers
{
    public class TestController : Controller
    {
        [Route("Test1")]
       public IActionResult Test1()
        {
            return View();
        }
    }
}
