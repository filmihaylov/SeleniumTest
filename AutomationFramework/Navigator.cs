using AutomationFramework.Selenium;
using AutomationFramework.SharedPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    public static class Navigator
    {
        public static void NavigateToHome()
        {
            Browser.Driver.Navigate().GoToUrl(Endpoints.HomePageURL);
        }
    }
}
