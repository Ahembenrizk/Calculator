using NUnit.Framework;
using FluentAssertions;

namespace CalculatorCore.Test
{
    using CalculatorCore.Strategies;

    public class PourcentageTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            this._calculatorInterface = new Pourcentage();
        }

        [Test]
        public void ShouldGetDoOperationWhenUsingConcreteAdditionAndAddingOneAndThreeMustReturnFour()
        {
            Assert.AreEqual(this._calculatorInterface.DoOperation(100, 0.25), 25);
        }
    }
}