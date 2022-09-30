using Microsoft.AspNetCore.Mvc;

namespace PierreVandO.Controllers
{
	public class OrdersController : Controller
	{
		[HttpGet("/orders")]
		public ActionResult Index() 
		{
			List<Order> orderList = Orders.GetOrders();
			return View(orderList);
		}
	}
}