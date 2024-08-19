using Microsoft.AspNetCore.Mvc;
using Testapplication.Models;

namespace Testapplication.Controllers
{
	public class SIController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(SI obj)
		{
			ViewBag.result ="SI is"+ (obj.P * obj.Q * obj.R)/100;
			return View();


		}
	}
}
