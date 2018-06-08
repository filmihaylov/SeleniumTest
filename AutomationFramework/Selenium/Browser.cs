using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Selenium
{
    public class Browser
    {
        public static IWebDriver Driver
        {
            get
            {
                if(driver == null)
                {
                    Initilize();
                    return driver;
                }
                else
                {
                    return driver;
                }
            }
        }

        private static IWebDriver driver = null;

        public static void Initilize()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Clean()
        {
            driver.Close();
        }
    }
}
