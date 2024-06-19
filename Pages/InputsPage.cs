using Homework_17.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Pages
{
    internal class InputsPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
        }

        private static IWebElement inputField = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@type ='number']")));

        public void ClickArrowUp() => inputField.SendKeys(Keys.ArrowUp);
        public void ClickArrowDown() => inputField.SendKeys(Keys.ArrowDown);
        public string GetFieldValue() => inputField.GetAttribute("value");

        public void ClearField()
        {
            for(int a = 0; a < 5; a++)
            {
                inputField.SendKeys(Keys.Backspace);
            }
        }
        
        public void EnterIntoTheField(string n)
        {
            inputField.SendKeys(n);
        }
    }
}
