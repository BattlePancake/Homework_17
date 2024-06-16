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
    internal class SortTableTest
    {
        [SetUp]
        public void Setup() => SortTablePage.OpenPage();

        [Test]
        public void SortTableTest1()
        {
            var sortTablePage = new SortTablePage();

            var text1 = sortTablePage.ElementOne.Text;
            var result1 = text1.Equals(sortTablePage.elementOne);
            Assert.That(result1, Is.True);

            var text2 = sortTablePage.ElementTwo.Text;
            var result2 = text2.Equals(sortTablePage.elementTwo);
            Assert.That(result2, Is.True);
  
            var text3 = sortTablePage.ElementThree.Text;
            var result3 = text3.Equals(sortTablePage.elementThree);
            Assert.That(result3, Is.True);

            var text4 = sortTablePage.ElementFour.Text;
            var result4 = text4.Equals(sortTablePage.elementFour);
            Assert.That(result4, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
