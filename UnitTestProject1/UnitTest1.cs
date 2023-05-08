using GMKN_Inventory_Client_v2;
using Hotcakes.CommerceDTO.v1.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FilterMethod_EmptyName_CountTest()
        {
            Form1 uj = new Form1();
            List<ProductDTO> list = new List<ProductDTO>() {
            new ProductDTO() { Sku = "SkuTest" },
            new ProductDTO() {Sku = "NotSku" }
            };
            List<ProductDTO> result = uj.Filter(list, "","SkuTest");
            Assert.AreEqual(result.Count, 1);
        }

        [TestMethod]
        public void FilterMethod_EmptyName_ContentCheck()
        {
            Form1 uj = new Form1();
            List<ProductDTO> list = new List<ProductDTO>() {
            new ProductDTO() { Sku = "SkuTest" },
            new ProductDTO() {Sku = "NotSku" }
            };
            List<ProductDTO> result = uj.Filter(list, "", "SkuTest");
            Assert.AreEqual(result[0].Sku, "SkuTest");
        }

        [TestMethod]
        public void FilterMethod_NormalCase_ContentCheck()
        {
            Form1 uj = new Form1();
            List<ProductDTO> list = new List<ProductDTO>() {
            new ProductDTO() {ProductName = "póló", Sku = "SkuTest" },
            new ProductDTO() { ProductName = "nadrág",Sku = "SkuTest" }
            };
            List<ProductDTO> result = uj.Filter(list, "nadrág", "SkuTest");
            Assert.AreEqual(result[0].ProductName, "nadrág");
        }

        [TestMethod]
        public void ResponseShouldNotBeNull()
        {
            Form1 uj = new Form1();
            ListBox listBox = new ListBox();
            uj.loadProducts(listBox);
            Assert.IsNotNull(uj.response);
        }
    }
}
