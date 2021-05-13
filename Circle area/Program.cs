using System;

namespace Circle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                const double pi = 3.14;
                double radius;
                Console.Write("Enter the radius value: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Circle_area =" + pi * radius * radius);
                Console.WriteLine("==========================================");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
