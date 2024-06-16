using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
//Lesson 17
namespace Homework_17
{
    public class Test
    {

        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://www.google.by/");
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(60));
        }

        [Test]
        public void Test1()
        {
            const string searchText = "iphone 15 pro max";
            IWebElement searchField = driver.FindElement(By.Id("APjFqb"));
            searchField.SendKeys(searchText);
            searchField.SendKeys(Keys.Enter);
            IWebElement title = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='LC20lb MBeuO DKV0Md']")));
            //IWebElement title = driver.FindElement(By.XPath("//*[@class='LC20lb MBeuO DKV0Md']"));
            var text = title.Text;
            var result = text.ToLower().Contains(searchText);
            //var resultOne = text.Equals(searchText);
            Assert.That(result, Is.True);
            //Assert.That(resultOne, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

