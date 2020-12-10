using System;
using System.Collections.Generic;
using CalculatorCore.Interfaces;
namespace CalculatorCore.Strategies
{
    public class Pourcentage : CalculatorInterface
    {
        public double DoOperation(double value1, double value2)
        {
            return (value1 * value2);
        }
    }
}