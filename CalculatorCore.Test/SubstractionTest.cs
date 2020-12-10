using NUnit.Framework;
using FluentAssertions;

namespace CalculatorCore.Test
{
    using CalculatorCore.Strategies;

    public class SubstractionTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            this._calculatorInterface = new ConcreteSubstraction();
        }

        [Test]
        public void ShouldGetDoOperationWhenUsingConcreteSubstractionAndThreefromFiveMustReturntwo()
        {
            Assert.AreEqual(this._calculatorInterface.DoOperation(5, 3), 2);
        }
    }
}