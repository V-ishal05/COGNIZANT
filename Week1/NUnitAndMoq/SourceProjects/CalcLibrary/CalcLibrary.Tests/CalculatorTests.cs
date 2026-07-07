using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        [TestCase(-5, 5, 0)]
        [TestCase(50, -10, 40)]
        public void Addition_Test(int a, int b, int expected)
        {
            Assert.That(calculator.Addition(a, b), Is.EqualTo(expected));
        }

        [TestCase(20, 5, 15)]
        [TestCase(10, 10, 0)]
        [TestCase(5, 10, -5)]
        [TestCase(-10, -5, -5)]
        public void Subtraction_Test(int a, int b, int expected)
        {
            Assert.That(calculator.Subtraction(a, b), Is.EqualTo(expected));
        }

        [TestCase(2, 3, 6)]
        [TestCase(10, 10, 100)]
        [TestCase(-5, 5, -25)]
        [TestCase(0, 20, 0)]
        public void Multiplication_Test(int a, int b, int expected)
        {
            Assert.That(calculator.Multiplication(a, b), Is.EqualTo(expected));
        }

        [TestCase(20, 4, 5)]
        [TestCase(100, 10, 10)]
        [TestCase(9, 3, 3)]
        [TestCase(-20, 5, -4)]
        public void Division_Test(int a, int b, double expected)
        {
            Assert.That(calculator.Division(a, b), Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                calculator.Division(10, 0);
            });
        }

        [Test]
        public void GetResult_Test()
        {
            calculator.Addition(10, 15);

            Assert.That(calculator.GetResult, Is.EqualTo(25));
        }

        [Test]
        public void AllClear_Test()
        {
            calculator.Addition(20, 30);

            calculator.AllClear();

            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }
    }
}