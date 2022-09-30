using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVandO.Models;
using System;

namespace PierreVandO.Tests
{
	[TestClass]
	public class VendorTests
	{
		[TestMethod]
		public void VendorConstructor_CreatesVendor_Vendor()
		{
			Vendor vendor = new Vendor("Vendy", "Loves to Vend");
			Assert.AreEqual(typeof(Vendor), vendor.GetType());
		}
	}
}