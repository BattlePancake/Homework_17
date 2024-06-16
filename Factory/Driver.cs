using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Homework_17.Factory
{
    internal class Driver
    {
        private static IWebDriver? _driver;
        private static WebDriverWait? _wait;

        Actions action = new Actions(_driver);
        

        public static WebDriverWait GetWait(int v) => _wait ??= new(_driver, TimeSpan.FromSeconds(v));

        public static IWebDriver GetDriver() => _driver ??= SetupDriver();

        public static void QuitDriver() => _driver.Quit();

        private static IWebDriver SetupDriver() => new ChromeDriver(GetOptions());

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }
    }
}
