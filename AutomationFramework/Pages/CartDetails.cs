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
    public class CartDetails : IPage
    {
        public static ProductDTO PopulateProductDTO()
        {
            var productTitle = Browser.Driver.FindElement(By.XPath("//*[@id=\"activeCartViewForm\"]//div[@class=\"a-fixed-left-grid-col a-col-right\"]/ul/li[1]/span[@class=\"a-list-item\"]/a[@class=\"a-link-normal sc-product-link\"]/span"));

            string title = productTitle.Text.Trim();
            ProductDTO product = new ProductDTO()
            {
                Title = title
            };

            return product;
        }
    }
}
