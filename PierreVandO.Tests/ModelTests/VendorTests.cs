using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVandO.Models;
using System;

namespace PierreVandO.Tests
{
	[TestClass]
	public class VendorTests : IDisposable
	{
		public void Dispose()
		{
			Vendor.ClearVendors();
		}
		
		[TestMethod]
		public void VendorConstructor_CreatesVendor_Vendor()
		{
			Vendor vendor = new Vendor("Vendy", "Loves to Vend");
			Assert.AreEqual(typeof(Vendor), vendor.GetType());
		}

		[TestMethod]
		public void VendorConstructor_HoldsName_String()
		{
			Vendor vendor = new Vendor("Vendy", "Loves to Vend");
			Assert.AreEqual("Vendy", vendor.VendorName);
		}

		[TestMethod]
		public void GetVendors_ReturnsVendors_List()
		{
			Vendor vendor1 = new Vendor("Businesso", "Requires Vendors to Live");
			Vendor vendor2 = new Vendor("Vendy", "Loves to Vend");
			Vendor vendor3 = new Vendor("Reginald Exchangington III", "Buying and Selling Items: Can't Imagine Life without It.");
			List<Vendor> vendorList1 = new List<Vendor> {vendor1, vendor2, vendor3};
			List<Vendor> vendorList2 = Vendor.GetVendors();
			Assert.AreEqual(vendorList1[2], vendorList2[2]);
		}

		[TestMethod]
		public void FindVendor_ReturnsVendor_Vendor()
		{
			Vendor vendor1 = new Vendor("Businesso", "Requires Vendors to Live");
			Vendor vendor2 = new Vendor("Vendy", "Loves to Vend");
			Vendor vendor3 = new Vendor("Reginald Exchangington III", "Buying and Selling Items: Can't Imagine Life without It.");
			Vendor foundVendor = Vendor.FindVendor(2);
			Assert.AreEqual(foundVendor, vendor2);
		}
	}
}