using Microsoft.AspNetCore.Mvc;
using PierreVandO.Models;
using System;
using System.Collections.Generic;

namespace PierreVandO.Controllers
{
	public class VendorsController : Controller
	{
		[HttpGet("/vendors")]
		public ActionResult Index() 
		{
			List<Vendor> vendorList = Vendor.GetVendors();
			return View(vendorList);
		}

		[HttpGet("/vendors/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/vendors")]
		public ActionResult Create(string name, string desc)
		{
			Vendor vendor = new Vendor(name, desc);
			return RedirectToAction("Index");
		}

		[HttpGet("/vendors/{vendorId}")]
		public ActionResult Show(int vendorId)
		{
			Dictionary<string, object> model = new Dictionary<string, object>();
			Vendor vendor = Vendor.FindVendor(vendorId);
			List<Order> orderList = vendor.VendorOrders;
			model.Add("vendor", vendor);
			model.Add("orders", orderList);
			return View(model);
		}

		[HttpPost("/vendors/{vendorId}/orders")]
		public ActionResult Create(int vendorId, string name, string desc, string price, string date)
		{
			Dictionary<string, object> model = new Dictionary<string, object>();
			Vendor vendor = Vendor.FindVendor(vendorId);
			Order order = new Order(name, desc, price, date);
			vendor.AddOrder(order);
			List<Order> orderList = vendor.VendorOrders;
			model.Add("vendor", vendor);
			model.Add("orders", orderList);
			return View("Show", model);
		}
	}
}