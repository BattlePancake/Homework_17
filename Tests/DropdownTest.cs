using Homework_17.Factory;
using Homework_17.Pages;

namespace Homework_17.Tests
{
    internal class DropdownTest
    {
        [SetUp]
        public void Setup() => DropdownPage.OpenPage();

        [Test]
        public void DropdownTest1()
        {
            var dropdownPage = new DropdownPage();

            dropdownPage.ClickDropdown();
            dropdownPage.ChooseOptionOne();

            var result = dropdownPage.GetAttributeOptionOne().Equals("1");
            Assert.That(result, Is.True);

            dropdownPage.ClickDropdown();
            dropdownPage.ChooseOptionTwo();

            var result1 = dropdownPage.GetAttributeOptionTwo().Equals("2");
            Assert.That(result1, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}