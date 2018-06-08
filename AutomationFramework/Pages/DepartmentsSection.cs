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
    public class DepartmentsSection : IPage
    {
        public static void Expand()
        {
            var expand = Browser.Driver.FindElement(By.XPath("//*[@id=\"leftNavContainer\"]/ul[@class=\"a-unordered-list a-nostyle a-vertical a-spacing-base\"]/div/li[6]"));
            expand.Click();
        }

        public static void SelectToysAndGames()
        {
            var department = Browser.Driver.FindElement(By.XPath("//*[@id=\"leftNavContainer\"]/ul[1]/div/div/li[6]"));
            department.Click();
        }
    }
}
