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
			
		}


	}
}