using Microsoft.AspNetCore.Mvc;

namespace PierreVandO.Controllers
{
	public class VendorsController : Controller
	{
		[HttpGet("/vendors")]
		public ActionResult Index() 
		{
			return View();
		}
	}
}