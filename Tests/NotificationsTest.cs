using Homework_17.Factory;
using Homework_17.Pages;
using OpenQA.Selenium.Interactions;

namespace Homework_17.Tests
{
    internal class NotificationsTest
    {
        [SetUp]
        public void Setup() => NotificationsPage.OpenPage();
        Actions action = new Actions(Driver.GetDriver());

        [Test]
        public void NotificationsTest1()
        {
            var notificationsPage = new NotificationsPage();

            notificationsPage.ClickLink();
            Assert.That(notificationsPage.NotificationExists(), Is.True);
 
            var result3 = notificationsPage.CompareTheText(notificationsPage.GetNotificationText());
            Assert.That(result3, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}