using Homework_17.Factory;
using Homework_17.Pages;
using OpenQA.Selenium.Interactions;

namespace Homework_17.Tests
{
    internal class HoversTest
    {
        [SetUp]
        public void Setup() => HoversPage.OpenPage();
        Actions action = new Actions(Driver.GetDriver());

        [Test]
        public void HoversTest1()
        {
            var hoversPage = new HoversPage();

            hoversPage.HoverOnProfile(1);
            var username1 = hoversPage.GetUsername(1);
            var result1 = hoversPage.CompareTheUsername(username1);
            Assert.That(result1, Is.True);

            hoversPage.ClickLink(1);
            Assert.That(hoversPage.ErrorExists(), Is.True);
        }
        [Test]
        public void HoversTest2()
        {
            var hoversPage = new HoversPage();

            hoversPage.HoverOnProfile(2);
            var username2 = hoversPage.GetUsername(2);
            var result2 = hoversPage.CompareTheUsername(username2);
            Assert.That(result2, Is.True);

            hoversPage.ClickLink(2);
            Assert.That(hoversPage.ErrorExists(), Is.True);
        }
        [Test]
        public void HoversTest3()
        {
            var hoversPage = new HoversPage();

            hoversPage.HoverOnProfile(3);
            var username3 = hoversPage.GetUsername(3);
            var result3 = hoversPage.CompareTheUsername(username3);
            Assert.That(result3, Is.True);

            hoversPage.ClickLink(3);
            Assert.That(hoversPage.ErrorExists(), Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}