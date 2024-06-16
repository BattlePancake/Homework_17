using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var firstValue = dropdownPage.GetAttributeOptionOne();
            var result = firstValue.Equals("1");
            Assert.That(result, Is.True);

            dropdownPage.ClickDropdown();
            dropdownPage.ChooseOptionTwo();

            var secondValue = dropdownPage.GetAttributeOptionTwo();
            var result1 = secondValue.Equals("2");
            Assert.That(result1, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}