using Homework_17.Factory;
using Homework_17.Pages;

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
            var result1 = inputsPage.GetFieldValue().Equals("1");
            Assert.That(result1, Is.True);

            inputsPage.ClickArrowDown();
            var result2 = inputsPage.GetFieldValue().Equals("0");
            Assert.That(result2, Is.True);

            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            var result3 = inputsPage.GetFieldValue().Equals("-3");
            Assert.That(result3, Is.True);

            inputsPage.ClearField();
            inputsPage.EnterIntoTheField("123");
            var result4 = inputsPage.GetFieldValue().Equals("123");
            Assert.That(result4, Is.True);

            inputsPage.ClearField();
            inputsPage.EnterIntoTheField("abcd");
            var result5 = inputsPage.GetFieldValue().Equals("");
            Assert.That(result5, Is.True);
        }

            [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
