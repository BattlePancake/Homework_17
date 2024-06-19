using Homework_17.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Pages
{
    internal class TyposPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
        }

        private const string referenceStringOne = "This example demonstrates a typo being introduced. It does it randomly on each page load.";
        private const string referenceStringTwo = "Sometimes you'll see a typo, other times you won't.";

        public string StringOne() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[1]"))).Text;
        public string StringTwo() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[2]"))).Text;

        public bool CompareText(string n)
        {
            if (n == StringOne())
            {
                return StringOne().Equals(referenceStringOne);
            }
            else if (n == StringTwo())
            {
                return StringTwo().Equals(referenceStringTwo);
            }
            else
            {
                return false;
            }
        }
    }
}
