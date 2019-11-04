using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choosing the largest of three numbers.");

            Console.Write("First number: ");
            double a;
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Second number: ");
            double b;
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Third number: ");
            double c;
            double.TryParse(Console.ReadLine(), out c);

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The largest number is: " + a);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine("The largest number is: " + b);
            }
            else
            {
                Console.WriteLine("The largest number is: " + c);
            }

        }
    }
}
