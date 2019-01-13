using System;

namespace WhatsMyAgeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////write an application that:

            ////obtains the user's age
            ////prints "watch movies" if the user is under 18.
            ////prints "can buy cigarettes" if the user is 18 or over 18.
            ////prints "can buy alcohol" if the user is 21 or over 21.
            ////prints the text for each valid condition.
            ////waits for the user to press a key before the program exits.


            Console.WriteLine("What's your age?");
            Console.Write("> ");
            var _age = Console.ReadLine();

            Console.WriteLine("Your age is {0}", _age);
            int _a;

            int.TryParse(_age, out _a);


            if (_a < 18)
            {

                Console.WriteLine("Watch Movies (less than 18)");
            }
            else if (_a < 21)
            {

                Console.WriteLine("Can buy cigarettes (less than 21)");
            }
            else if (_a >= 21)
            {

                Console.WriteLine("Can buy alcohol");
            }


            Console.ReadKey();
        }
    }
}
