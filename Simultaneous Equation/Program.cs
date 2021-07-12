using System;

namespace Simultaneous_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving a simultaneous equation using cramers rule;\n ax + by = e \n cx + dy = f");
            Console.WriteLine("Enter your value for a, b, e, c, d, f");
            Console.WriteLine("a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e: ");
            double e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d: ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("f: ");
            double f = Convert.ToInt32(Console.ReadLine());

            double x = (e * d - b * f) / (a * d - b * c);
            double y = (a * f - e * c) / (a * d - b * c);

            if (a * d - b * c == 0)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("X is " + x);
                Console.WriteLine("Y is " + y);
            }


        }
    }
}
