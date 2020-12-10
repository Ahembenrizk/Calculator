using NUnit.Framework;
using FluentAssertions;

namespace CalculatorCore.Test
{
    using CalculatorCore.Strategies;

    public class DivideTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            this._calculatorInterface = new ConcreteDivide();
        }

        [Test]
        public void ShouldGetDoOperationWhenUsingConcreteDivideAndDivideFourByTwoMustReturnTwo()
        {
            Assert.AreEqual(this._calculatorInterface.DoOperation(4, 2), 2);
        }
    }
}