using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesEShop.Controllers
{
    [Authorize]
    public class MyTestController: Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        // https://localhost:xxx/MyTest/Test <---- GET METHOD
        public ActionResult Test()
        {
            Console.WriteLine("Inside Test Controller");
            return View();
        }
    }
}