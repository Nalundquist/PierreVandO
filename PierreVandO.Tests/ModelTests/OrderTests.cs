using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVandO.Models;
using System;

namespace PierreVandO.Tests
{
	[TestClass]
	public class OrderTests : IDisposable
	{
		public void Dispose()
		{
			Order.ClearOrders();
		}

		[TestMethod]
		public void OrderConstructor_CreatesOrder_Order()
		{
			Order order = new Order("Ordie", "Adores containing Items", "$1.99", "Fleburary 33rd, 2099");
			Assert.AreEqual(typeof(Order), order.GetType());
		}

		[TestMethod]
		public void OrderConstructor_HoldsPrice_String()
		{
			Order order = new Order("Ordie", "Adores containing Items", "$1.99", "Fleburary 33rd, 2099");
			Assert.AreEqual("$1.99", order.OrderPrice);
		}
		
		[TestMethod]
		public void GetOrders_ReturnsOrders_List()
		{
			Order order1 = new Order("Listle", "Overflowing with Eclairs", "$11.99", "Smarch 50th, 2099");
			Order order2 = new Order("Purchesa", "Full of Croissants", "$10.99", "Orgust 1rd, 2099");
			Order order3 = new Order("Ordie", "Adores containing Items", "$1.99", "Fleburary 33rd, 2099");
			List<Order> orderList = new List<Order> {order1, order2, order3};
			Assert.AreEqual(orderList, Order.GetOrders());
		}
	}
}