using NUnit.Framework;

namespace CalculatorCore.Test
{
    using CalculatorCore.Interfaces;

    public abstract class BaseTest
    {
        protected CalculatorInterface _calculatorInterface;

        [TearDown]
        public void Clear()
        {
           this._calculatorInterface = null;
        }
    }
}