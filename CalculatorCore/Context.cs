using CalculatorCore.Interfaces;
using System;
using System.Collections.Generic;
using CalculatorCore.Strategies;

namespace CalculatorCore
{
    public class Context
    {
        // define the interface ICalculate 
        private CalculatorInterface _calculate;

        public Context()
        { }

        // Constuctor 
        public Context(CalculatorInterface calculate)
        {
            this._calculate = calculate;
        }

        // Usually, the Context allows replacing a Calculate object at runtime.
        public void SetCalculator(CalculatorInterface calculate)
        {
            this._calculate = calculate;
        }


        public double Do(double value1, double value2)
        {
            return this._calculate.DoOperation(value1, value2);
        }
    }
}