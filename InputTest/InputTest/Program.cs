using System;

namespace InputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}
