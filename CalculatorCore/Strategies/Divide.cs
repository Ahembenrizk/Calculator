using System;
using System.Collections.Generic;
using CalculatorCore.Interfaces;

namespace CalculatorCore
{
    public class ConcreteDivide : CalculatorInterface 
    {
        public  double DoOperation (double value1 , double value2)
        {
            /* if (value2 == 0)
            {
                new DivideByZeroException();
            }*/
            
            return value1/value2;

        }
     
    }

}