using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double radius;

            Console.WriteLine("What is the radius of your circle?");

            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Area of your circle is {0}", radius*radius * PI);
        }
    }
}
