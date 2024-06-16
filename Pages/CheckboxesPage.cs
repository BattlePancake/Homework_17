using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_17.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Pages
{
    internal class CheckboxesPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");
        }
        public IWebElement firstCheckbox = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()=' checkbox 1']//input[1]")));
        public IWebElement secondCheckbox = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()=' checkbox 1']//input[2]")));

        public void ClickCheckBoxOne() => firstCheckbox.Click();
        public void ClickCheckBoxTwo() => secondCheckbox.Click();

        public bool IsChecked(string Attribute)
        {
            if (Attribute == "null")
            {
                return false;
            }
            else if (Attribute == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CheckedOne() => firstCheckbox.GetAttribute("checked");
        public string CheckedTwo() => secondCheckbox.GetAttribute("checked");
    }
}