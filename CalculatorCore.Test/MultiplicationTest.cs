using NUnit.Framework;
using FluentAssertions;

namespace CalculatorCore.Test
{
    using CalculatorCore.Strategies;

    public class MultiplicationTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            this._calculatorInterface = new ConcreteMultipliction();
        }

        [Test]
        public void ShouldGetDoOperationWhenUsingConcreteMultiplictionAndMulplieFiveAndThreeMustReturnFifteen()
        {
            Assert.AreEqual(this._calculatorInterface.DoOperation(5, 3), 15);
        }
    }
}