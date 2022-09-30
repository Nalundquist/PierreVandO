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
			Order order = new Order("Ordie", "Adores containing Items");
			Assert.AreEqual(typeof(Order), order.GetType());
		}
	}
}