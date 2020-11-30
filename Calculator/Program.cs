using System;
using System.Collections.Generic;

namespace calculator
{

    class Context
    {
        // define the interface ICalculate 
        private ICalculate _calculate;

        public Context()
        { }

        // Constuctor 
        public Context(ICalculate calculate)
        {
            this._calculate = calculate;
        }

        // Usually, the Context allows replacing a Calculate object at runtime.
        public void SetCalculate(ICalculate calculate)
        {
            this._calculate = calculate;
        }

        // The Context delegates some work to the Calculate object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoSomeBusinessLogic()
        {
           
        }
    }
    //----------------------------------------------------------------------les 4 Operation
    class ConcreteCalculateAddition : ICalculate 
    {
        double result = double.NaN;

        // ----------------l'addition 
        public static double DoOperation(double value1, double value2, double result)
        {
            result = value1 + value2;
            return result;
        }

    }
    class ConcreteCalculateSoustraction : ICalculate
    { 
//-------------------- la soustraction
        public static double DoOperation(double value1, double value2, double result)
        {
            result = value1 - value2 ;
            return result;
        }
    }
    class ConcreteCalculateMultiplication : ICalculate
    {
        // -----------------la Multiplication 
        public static double DoOperation(double value1, double value2, double result )
        {
            result = value1 * value2;
            return result;
        }
    }
    class ConcreteCalculateDivision : ICalculate
    {
        //---------------------- la Division 
        public static double DoOperation(double value1, double value2, double result )
        {
            if (value2 != 0)
            {
                result = value1 / value2;
            }
            return result;
        }
    }
  //----------------------------------------------------------------------------------------------------    


    

   
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculate \r");
            Console.WriteLine("------------------------\n");

            context.SetCalculate(new ConcreteCalculateAddition());
         


            bool endApp = false;
        

            while (!endApp)
            {
                // ------------------Declaration des variables 
                string valueInput1 = "";
                string valueInput2 = "";
                double result = 0;
                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                valueInput1 = Console.ReadLine();

                double cleanValue1 = 0;
                while (!double.TryParse(valueInput1, out cleanValue1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    valueInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                valueInput2 = Console.ReadLine();

                double cleanValue2 = 0;
                while (!double.TryParse(valueInput2, out cleanValue2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    valueInput2 = Console.ReadLine();
                }


                // Ask the user to choose an operator.
                Console.WriteLine("Select an operator from the list below :");
                Console.WriteLine("\t + - Addition");
                Console.WriteLine("\t - - Soustraction");
                Console.WriteLine("\t * - Multiplication");
                Console.WriteLine("\t / - Division");

                string operat = Console.ReadLine();

                switch (operat)
                {
                    case "+":
                    
                        Console.WriteLine("Addition  \n");
                        context.SetCalculate(new ConcreteCalculateAddition());
                        context.DoSomeBusinessLogic();
                        break;

                    case "-": 

                        Console.WriteLine("Soustraction  \n");
                        context.SetCalculate(new ConcreteCalculateSoustraction());
                        context.DoSomeBusinessLogic();
                        break;

                    case "*":
                        
                        Console.WriteLine("Multiplication  \n");
                        context.SetCalculate(new ConcreteCalculateMultiplication());
                        context.DoSomeBusinessLogic();
                        break;

                    case "/":

                        Console.WriteLine("Divison  \n");
                        context.SetCalculate(new ConcreteCalculateDivision());
                        context.DoSomeBusinessLogic();
                        break;

                    default:
                        break;
                }
                try
                {
                    result = ICalculate.DoOperation(cleanValue1, cleanValue1, operat);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine("Press any key to exit \n");
                //Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                //if (Console.ReadLine() == "n") endApp = true;

                //Console.WriteLine("\n"); 
            }
        
            return;

        }
    }
}


