using Homework_17.Factory;
using Homework_17.Pages;

namespace Homework_17.Tests
{
    internal class TyposTest
    {

        [SetUp]
        public void Setup() => TyposPage.OpenPage();

        [Test]
        public void TyposTest1()
        {
            var typosPage = new TyposPage();

            var result1 = typosPage.CompareText(typosPage.StringOne());
            Assert.That(result1, Is.True);

            var result2 = typosPage.CompareText(typosPage.StringTwo());
            Assert.That(result2, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
