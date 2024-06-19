using OpenQA.Selenium;
using Homework_17.Factory;
using Homework_17.Pages;

namespace Homework_17.Tests
{
    public class AddRemoveTest
    {
        [SetUp]
        public void Setup() => AddRemovePage.OpenPage();

        [Test]
        public void AddRemoveTest1()
        {
            var addRemovePage = new AddRemovePage();
            addRemovePage.AddElement();
            addRemovePage.AddElement();
            addRemovePage.DeleteElement();
            var visible1 = addRemovePage.IsFirstElementVisible();
            Assert.That(visible1, Is.True);

            var visible2 = false;
            try
            {
                visible2 = addRemovePage.IsSecondElementVisible();
            }
            catch(WebDriverTimeoutException)
            {
                visible2 = false;
            }
            Assert.That(visible2, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}

