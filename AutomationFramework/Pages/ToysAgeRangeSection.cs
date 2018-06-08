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
    public class ToysAgeRangeSection : IPage
    {
        public static void SelectFourteenYearsUp()
        {
            var checkbox = Browser.Driver.FindElement(By.XPath("//*[@id=\"leftNavContainer\"]/ul[7]/div/li[5]/span/span/div/label/input"));
            checkbox.Click();
        }
    }
}
