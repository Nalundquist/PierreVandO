using System;
using System.Collections.Generic;

namespace PierreVandO.Models
{
	public class Order
	{
		private static List<Order> _orderList = new List<Order> {}; 
		public string OrderName { get; set; }
		public string OrderDesc { get; set; }
		public string OrderPrice { get; set; }
		public string OrderDate { get; set; }
		public int OrderId { get; }

		public Order(string name, string desc, string price, string date)
		{
			
		}


	}
}