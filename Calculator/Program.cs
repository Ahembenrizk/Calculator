using System;
using System.Collections.Generic;
using CalculatorCore;
using CalculatorCore.Strategies;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculate \r");
            Console.WriteLine("------------------------\n");

            // context.SetCalculate(new ConcreteCalculateAddition());



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
                Console.WriteLine("\t / - Divide");

                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":

                        Console.WriteLine("Addition  \n");
                        context.SetCalculator(new ConcreteAddition());
                        break;

                    case "-":

                        Console.WriteLine("Substraction  \n");
                        context.SetCalculator(new ConcreteSubstraction());
                        break;

                    case "*":

                        Console.WriteLine("Multiplication  \n");
                        context.SetCalculator(new ConcreteMultipliction());
                        break;

                    case "/":

                        Console.WriteLine("Divison  \n");
                        context.SetCalculator(new ConcreteDivide());
                        break;

                    default:
                        break;
                }
                try
                {
                    result = context.Do(cleanValue1, cleanValue2);
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
                //   Console.WriteLine("Press any key to exit \n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }

            return;

        }
    }
}


