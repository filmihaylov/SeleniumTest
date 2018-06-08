using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.DTOs;
using AutomationFramework.Selenium;
using AutomationFramework.SharedPages;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class ProductDetailsSection : IPage
    {
        public static void SelectQuantity(int quantity)
        {
            Wait.WaitTime(6000);
            var quantityDropDown = Browser.Driver.FindElement(By.Id("quantity"));
            var option = quantityDropDown.FindElement(By.CssSelector($"option[value='{quantity}']"));
            option.Click();
        }

        public static ProductDTO PopulateProductDTO()
        {
            var productTitle = Browser.Driver.FindElement(By.Id("productTitle"));
            string title = productTitle.Text.Trim();
            ProductDTO product = new ProductDTO()
            {
                Title = title
            };

            return product;
        }

        public static void AddToCart()
        {
            var addToCArt = Browser.Driver.FindElement(By.Id("add-to-cart-button"));
            addToCArt.Click();
        }
    }
}
