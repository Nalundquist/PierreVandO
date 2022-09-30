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
		}

		public static List<Vendor> GetVendors()
		{
			List<Vendor> blankVendorList = new List<Vendor> {};
			return blankVendorList;
		}

		public static void ClearVendors()
		{
			_vendorList.Clear();
		}
	}
}