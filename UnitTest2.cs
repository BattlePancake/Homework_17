using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
//Homework Lesson 17
namespace Homework_17
{
    public class TestOne
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            //driver.Manage().Window.Maximize();
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://www.google.by/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [Test]
        public void Test1()
        {
            const string searchName = "calculator";
            IWebElement searchField = driver.FindElement(By.Id("APjFqb"));
            searchField.SendKeys(searchName);
            searchField.SendKeys(Keys.Enter);
            IWebElement calculator = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='XRsWPe UUhRt']")));
            IWebElement buttonNumberOne = driver.FindElement(By.XPath("//*[@jsname='N10B9']"));
            buttonNumberOne.Click();
            IWebElement buttonPlus = driver.FindElement(By.XPath("//*[@aria-label='сложение']"));
            buttonPlus.Click();
            IWebElement buttonNumberSeven = driver.FindElement(By.XPath("//*[@jsname='rk7bOd']"));
            buttonNumberSeven.Click();
            IWebElement buttonEquals = driver.FindElement(By.XPath("//*[@class='XRsWPe UUhRt']"));
            buttonEquals.Click();
            var waitForElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@jsname='VssY5c']")));
            var text = waitForElement.Text;
            var result = text.Equals("8");
            Assert.That(result, Is.True);
            IWebElement buttonDivide = driver.FindElement(By.XPath("//*[@jsname='WxTTNd']"));
            buttonDivide.Click();
            IWebElement buttonNumberTwo = driver.FindElement(By.XPath("//*[@jsname='lVjWed']"));
            buttonNumberTwo.Click();
            buttonEquals.Click();
            var waitForElement1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@jsname='VssY5c']")));
            var text1 = waitForElement1.Text;
            var result1 = text1.Equals("4");
            Assert.That(result1, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

