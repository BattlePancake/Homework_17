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

        private static IWebElement dropdown = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']")));
        private static IWebElement optionOne = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[2]")));
        private static IWebElement optionTwo = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[3]")));

        public void ClickDropdown() => dropdown.Click();
        public void ChooseOptionOne() => optionOne.Click();
        public void ChooseOptionTwo() => optionTwo.Click();

        public string GetAttributeOptionOne() => optionOne.GetAttribute("value");
        public string GetAttributeOptionTwo() => optionTwo.GetAttribute("value");
    }
}


