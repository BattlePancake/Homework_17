using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_17.Factory;
using Homework_17.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.IndexedDB;

namespace Homework_17.Tests
{
    internal class InputsTest
    {
        [SetUp]
        public void Setup() => InputsPage.OpenPage();

        [Test]
        public void InputsTest1()
        {
            var inputsPage = new InputsPage();

            inputsPage.ClickArrowUp();
            var text1 = inputsPage.GetFieldValue();
            var result1 = text1.Equals("1");
            Assert.That(result1, Is.True);

            inputsPage.ClickArrowDown();
            var text2 = inputsPage.GetFieldValue();
            var result2 = text2.Equals("0");
            Assert.That(result2, Is.True);

            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            var text3 = inputsPage.GetFieldValue();
            var result3 = text3.Equals("-3");
            Assert.That(result3, Is.True);

            inputsPage.ClearField();
            inputsPage.inputField.SendKeys("123");
            var text4 = inputsPage.GetFieldValue();
            var result4 = text4.Equals("123");
            Assert.That(result4, Is.True);

            inputsPage.ClearField();
            inputsPage.inputField.SendKeys("abcd");
            var text5 = inputsPage.GetFieldValue();
            var result5 = text5.Equals("");
            Assert.That(result5, Is.True);
        }

            [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
