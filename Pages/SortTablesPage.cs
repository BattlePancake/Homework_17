using Homework_17.Factory;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Pages
{
    internal class SortTablePage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
        }

        private const string _elementOne = "Smith";
        private const string _elementTwo = "$100.00";
        private const string _elementThree = "Tim";
        private const string _elementFour = "http://www.jsmith.com";

        public string ElementOne() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[1]//td[1]"))).Text;
        public string ElementTwo() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[3]//td[4]"))).Text;
        public string ElementThree() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[4]//td[2]"))).Text;
        public string ElementFour() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[1]//td[5]"))).Text;

        public bool CompareElement(int n)
        {
            if (n == 1)
            {
                return ElementOne().Equals(_elementOne);
            }
            else if (n == 2)
            {
                return ElementTwo().Equals(_elementTwo);
            }
            else if (n == 3)
            {
                return ElementThree().Equals(_elementThree);
            }
            else
            {
                return ElementFour().Equals(_elementFour);  
            }
        }
    }
}