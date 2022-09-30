using System;
using System.Collections.Generic;

namespace PierreVandO.Models
{
	public class Vendor
	{
		private static List<Vendor> _vendorList = new List<Vendor> {}; 
		public string VendorName { get; set; }
		public string VendorDesc { get; set; }
		public List<Order> VendorOrders { get; set; }
		public int VendorId { get; }

		public Vendor(string name, string desc)
		{
			VendorName = name;
			VendorDesc = desc;
			_vendorList.Add(this);
			VendorId = _vendorList.Count;
			VendorOrders = new List<Order> {};
		}

		public static List<Vendor> GetVendors()
		{
			return _vendorList;
		}

		public static void ClearVendors()
		{
			_vendorList.Clear();
		}

		public static Vendor FindVendor(int id)
		{
			Vendor vendor = _vendorList[id-1];
			return vendor;
		}

		public void AddOrder(Order order)
		{
			VendorOrders.Add(order);
		}
	}
}