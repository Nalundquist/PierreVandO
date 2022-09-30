using Microsoft.AspNetCore.Mvc;
using PierreVandO.Models;
using System;
using System.Collections.Generic;

namespace PierreVandO.Controllers
{
	public class OrdersController : Controller
	{
		[HttpGet("/orders")]
		public ActionResult Index() 
		{
			List<Order> orderList = Order.GetOrders();
			return View(orderList);
		}

		[HttpGet("/vendors/{vendorId}/orders/new")]
		public ActionResult New(int vendorId)
		{
			Vendor vendor = Vendor.FindVendor(vendorId);
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