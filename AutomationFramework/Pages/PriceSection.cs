using AutomationFramework.Selenium;
using AutomationFramework.SharedPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class PriceSection : IPage
    {
        public static void Filter(int minPrice, int maxPrice)
        {
            var minPriceBox = Browser.Driver.FindElement(By.Id("low-price"));
            minPriceBox.SendKeys(minPrice.ToString());
            var maxPriceBox = Browser.Driver.FindElement(By.Id("high-price"));
            maxPriceBox.SendKeys(maxPrice.ToString());
            var go = Browser.Driver.FindElement(By.XPath("//*[@class=\"a-button a-spacing-top-mini s-small-margin-left\"]/span/input"));
            go.Click();
        }
    }
}
