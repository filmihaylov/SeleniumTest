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
    public class Cart : IPage
    {
        public static void Details()
        {
            var cart = Browser.Driver.FindElement(By.Id("hlb-view-cart-announce"));
            cart.Click();
        }
    }
}
