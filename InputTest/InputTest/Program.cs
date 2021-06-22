using System;

namespace InputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing inputs

            /*
             * 
             * Multi Line comment
             */

            //var implicitly defines a variable type based on declaration

            var z = 1.1;

            //const cannot be changed after initial declaration
            const double PI = 3.12;

            string yourName;
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}
