using System;

namespace ConsoleAppFizzBuzz
{
    class Program
    {


        // Prints the numbers between 1 to 100 but:
        // Replaces all numbers divisible by 3 with Fizz
        // Replaces all numbers divisible by 5 with Buzz
        // Replaces all numbers divisible by both 3 and 5 with FizzBuzz
        // Ensure the user is able to see the result of the program.

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fizz Buzz Fun!!!!!");

            int _counter = 1;
            while (_counter <= 100)
            {
                bool _isFizz = false, _isBuzz=false;

                if (_counter % 3 == 0) {
                    _isFizz = true;
                }

                if (_counter % 5 == 0) {
                    _isBuzz = true;
                }

                if (_isFizz && _isBuzz)
                {
                    Console.WriteLine("Number {0} FizzBuzz", _counter);
                }
                else if (_isFizz)
                {
                    Console.WriteLine("Number {0} Fizz", _counter);
                }
                else if (_isBuzz)
                {
                    Console.WriteLine("Number {0} Buzz", _counter);
                }
                else {
                    Console.WriteLine("Number {0}", _counter);
                }



                _counter = _counter + 1;
            }

            Console.ReadLine();
        }

    }
}
