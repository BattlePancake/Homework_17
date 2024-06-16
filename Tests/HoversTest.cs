using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Homework_17.Factory;
using Homework_17.Pages;
using OpenQA.Selenium.Interactions;
using static System.Collections.Specialized.BitVector32;

namespace Homework_17.Tests
{
    internal class HoversTest
    {
        [SetUp]
        public void Setup() => HoversPage.OpenPage();

        [Test]
        public void HoversTest1()
        {
            var hoversPage = new HoversPage();

            action.MoveToElement(element).Perform();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
