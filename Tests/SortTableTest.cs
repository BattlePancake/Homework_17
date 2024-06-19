using Homework_17.Factory;
using Homework_17.Pages;

namespace Homework_17.Tests
{
    internal class SortTableTest
    {
        [SetUp]
        public void Setup() => SortTablePage.OpenPage();

        [Test]
        public void SortTableTest1()
        {
            var sortTablePage = new SortTablePage();

            var result1 = sortTablePage.CompareElement(1);
            Assert.That(result1, Is.True);

            var result2 = sortTablePage.CompareElement(2);
            Assert.That(result2, Is.True);

            var result3 = sortTablePage.CompareElement(3);
            Assert.That(result3, Is.True);

            var result4 = sortTablePage.CompareElement(4);
            Assert.That(result4, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
