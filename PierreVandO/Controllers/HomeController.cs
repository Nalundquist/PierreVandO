using Microsoft.AspNetCore.Mvc;

namespace PierreVandO.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index() {return View();}
	}
}