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
    public class Home : IPage
    {
        public static ProductListSection Search(string searchItem)
        {
            var searchBox = Browser.Driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(searchItem);
            var goButton = Browser.Driver.FindElement(By.CssSelector("input[value='Go']"));
            goButton.Click();

            return new ProductListSection();

        }
    }
}
