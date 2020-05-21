using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematika
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2 = 0;

            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + "x^2 + " + "(" + b + ")" + "x + " + "(" + c + ")");

            if (a == 0)
            {
                Console.WriteLine("a != 0");
                Console.ReadLine();
            }
            else
            {
                D = b * b - 4 * a * c;
                if (D >= 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Answer: x1 = " + x1 + " x2 = " + x2);
                }
                else
                {
                    Console.WriteLine("Error D < 0");
                }
            }
            Console.Read();
        }
    }
}
