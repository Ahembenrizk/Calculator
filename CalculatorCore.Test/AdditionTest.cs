using NUnit.Framework;
using FluentAssertions;

namespace CalculatorCore.Test
{
    using CalculatorCore.Strategies;

    public class AdditionTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            this._calculatorInterface = new ConcreteAddition();
        }

        [Test]
        public void ShouldGetDoOperationWhenUsingConcreteAdditionAndAddingOneAndThreeMustReturnFour()
        {
            Assert.AreEqual(this._calculatorInterface.DoOperation(1, 3), 4);
        }
    }
}