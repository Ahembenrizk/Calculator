namespace CalculatorCore
{
    public concreteCalculateDivide : CalculatorInterface 
    {
        public  double DoOperation (double value1 , double value2)
      if (value2 == 0)
            {
                new DivideByZeroException();
            }
            
            return value1 / value2;
    }

}