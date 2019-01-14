using System;

namespace ConsoleAppRecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please a number and I will computer the factorial using recursion > ");
            string _value = Console.ReadLine();
            var _recursiveAnswer = Factorial(int.Parse(_value));
            Console.WriteLine();
            Console.WriteLine("The answer is {0}", _recursiveAnswer.ToString());

            Console.ReadLine();
        }

        private static int Factorial(int n) {

           
            if (n == 1) {
                Console.WriteLine("Push {0} {1}", n, DateTime.Now.Ticks);
                return 1;
            }
            else {
                Console.WriteLine("Push {0} {1}", n, DateTime.Now.Ticks);
                return n * Factorial(n - 1);              
            }
           
        }


    }
}
