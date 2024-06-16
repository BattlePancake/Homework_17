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
    internal class DropdownPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
        }

        public IWebElement dropdown = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']")));
        public void ClickDropdown() => dropdown.Click();

        public IWebElement OptionOne = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[2]")));
        public IWebElement OptionTwo = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[3]")));

        public void ChooseOptionOne() => OptionOne.Click();
        public void ChooseOptionTwo() => OptionTwo.Click();

        public string GetAttributeOptionOne() => OptionOne.GetAttribute("value");
        public string GetAttributeOptionTwo() => OptionTwo.GetAttribute("value");
    }
}


