using System;
using AutomationFramework;
using AutomationFramework.DTOs;
using AutomationFramework.Pages;
using AutomationFramework.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest
{
    [TestClass]
    public class AmazonShoppingCartTest
    {
        [ClassInitialize]
        public static void Initiliaze(TestContext context)
        {
            Browser.Initilize();
        }


        [TestMethod]
        public void TestItemAddedToShoppingCart()
        {  
                Navigator.NavigateToHome();
                Home.Search("Harry Potter");
                DepartmentsSection.Expand();
                DepartmentsSection.SelectToysAndGames();
                PriceSection.Filter(10, 150);
                ToysAgeRangeSection.SelectFourteenYearsUp();
                ProductListSection.SelectFirst();
                ProductDetailsSection.SelectQuantity(4);
                ProductDTO productFromProductDetailsPage = ProductDetailsSection.PopulateProductDTO();
                ProductDetailsSection.AddToCart();
                Cart.Details();
                ProductDTO productFromCartDetails = CartDetails.PopulateProductDTO();
                Assert.AreEqual(productFromCartDetails, productFromProductDetailsPage, "Item in search list and in shopping cart are not the same");      
        }

        [ClassCleanup]
        public static void Clean()
        {
            Browser.Clean();
        }

    }
}
