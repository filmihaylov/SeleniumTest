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
    public class ProductListSection : IPage
    {
        public static void SelectFirst()
        {
            Wait.WaitTime(6000);
            var first = Browser.Driver.FindElement(By.XPath("//*[@id=\"result_0\"]/div[@class=\"s-item-container\"]//h2"));
            first.Click();

        }
    }
}
