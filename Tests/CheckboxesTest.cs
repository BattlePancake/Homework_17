using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_17.Factory;
using Homework_17.Pages;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_17.Tests
{
    internal class CheckboxesTest
    {
        [SetUp]
        public void Setup() => CheckboxesPage.OpenPage();

        [Test]
        public void CheckboxesTest1()
        {
            var checkBoxPage = new CheckboxesPage();

            var result1 = checkBoxPage.IsChecked(checkBoxPage.CheckedOne());
            Assert.That(result1, Is.False);

            checkBoxPage.ClickCheckBoxOne();

            var result2 = checkBoxPage.IsChecked(checkBoxPage.CheckedOne());
            Assert.That(result2, Is.True);

            var result3 = checkBoxPage.IsChecked(checkBoxPage.CheckedTwo());
            Assert.That(result3, Is.True);

            checkBoxPage.ClickCheckBoxTwo();

            var result4 = checkBoxPage.IsChecked(checkBoxPage.CheckedTwo());
            Assert.That(result4, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
