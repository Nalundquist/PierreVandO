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
			OrderName = name;
			OrderDesc = desc;
			OrderPrice = price;
			OrderDate = date;
			_orderList.Add(this);
			OrderId = _orderList.Count;
		}

		public static List<Order> GetOrders()
		{
			return _orderList;
		}

		public static void ClearOrders()
		{
			_orderList.Clear();
		}

		public static Order FindOrder(int id)
		{
			Order order = _orderList[id-1];
			return order;
		}
	}
}