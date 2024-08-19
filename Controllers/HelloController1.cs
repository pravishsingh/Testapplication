using Microsoft.AspNetCore.Mvc;

namespace Testapplication.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // for acction method
        public  IActionResult Index(IFormCollection obj)// iformcollection merge the content of of input store the content of input
        {
            int num1 = Convert.ToInt32(obj["txtnum1"].ToString());// data come into the obj form
            int num2 = Convert.ToInt32(obj["txtnum2"].ToString());
            int num3 = num1 + num2;
            ViewBag.data = "Result is " + num3;// view bag is object help to move data from controller to view...
            return View();
        }

    }
}
