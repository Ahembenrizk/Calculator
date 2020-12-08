using CalculatorCore.Interfaces;

namespace CalculatorCore
{
    public class ConcreteSubstraction : CalculatorInterface
    {
        public double DoOperation(double value1, double value2)
        {
            return value1 - value2;
        }
    }

}