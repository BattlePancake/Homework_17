using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var text1 = typosPage.StringOne.Text;
            var result1 = text1.Equals(typosPage.referenceStringOne);
            Assert.That(result1, Is.True);

            var text2 = typosPage.StringTwo.Text;
            var result2 = text2.Equals(typosPage.referenceStringTwo);
            Assert.That(result2, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
