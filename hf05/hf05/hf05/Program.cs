using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates the larger ratio of two numbers.");

            Console.Write("First number: ");
            double a;
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Second number: ");
            double b;
            double.TryParse(Console.ReadLine(), out b);

            if (a > b)
            {
                if (b == 0)
                {
                    Console.WriteLine("You can't divide by 0!");
                }
                else
                {
                    double ratio1 = a / b;
                    Console.WriteLine("The ratio: " + ratio1);
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("You can't divide by 0!");
            }
            else
            {
                double ratio2 = b / a;
                Console.WriteLine("The ratio: " + ratio2);
            }
        }
    }
}
