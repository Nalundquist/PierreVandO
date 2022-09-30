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

		[HttpGet("/vendors/{vendorId}/orders/new")]
		public ActionResult New(int vendorId)
		{
			Vendor vendor = Vendor.FindVendor(id);
			return View(vendor);
		}

		[HttpGet("/vendors/{vendorId}/orders/{orderId}")]
		public ActionResult Show(int vendorId, int orderId)
		{
			Order order = Order.FindOrder(orderId);
			Vendor vendor = Vendor.FindVendor(vendorId);
			Dictionary<string, object> model = new Dictionary<string, object>();
			model.Add("order", order);
			model.Add("vendor", vendor);
			return View(model);
		}
	}
}