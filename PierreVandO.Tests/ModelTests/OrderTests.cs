using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVandO.Models;
using System;

namespace PierreVandO.Tests
{
	[TestClass]
	public class OrderTests
	{
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
			Assert.AreEqual("$1.99", order.Price);
		}
	}
}