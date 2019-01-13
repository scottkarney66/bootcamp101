using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Write an application that is able to:
            ////Obtain 2 decimals from the user.
            ////Obtain one of the following math operations from the user. (Add, Subtract, Multiply or Divide)
            ////Calculate the result of the chosen math operation using the 2 supplied numbers.
            ////Print out the calculated result.
            ///

            Console.Write("Please enter a decimal value > ");
            string _firstValue = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter another decimal value > ");
            string _secondValue = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter an operation you want to perform on the two values:");
            Console.Write("ADD - TYPE \"a\" ENTER, SUBTRACT - TYPE \"s\" ENTER, MULTIPLY - TYPE \"m\" ENTER, DIVIDE - TYPE \"d\" > ");
            string _operation = Console.ReadLine();
            Console.WriteLine();


            string _output = "";

            switch (_operation)
            {

                case "a":
                    {
                        Calculator.Add(_firstValue, _secondValue);
                        break;
                    }

                case "s":
                    {
                        Calculator.Subtract(_firstValue, _secondValue);
                        break;
                    }

                case "m":
                    {
                        Calculator.Multiply(_firstValue, _secondValue);
                        break;
                    }

                case "d":
                    {
                        Calculator.Divide(_firstValue, _secondValue);
                        break;
                    }

                default:
                    _output = "did not enter \"a\",\"s\",\"m\",\"d\"";
                    break;
            }

            Console.WriteLine(_output);
            Console.ReadKey();
        }
    }
}
