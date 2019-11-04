using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf07
{
    class Program
    {
        static int Fact(int i)
        {
            int fact = 1;

            if (i == 0)
            {
                return fact;
            }
            else
            {
                while(i > 0)
                {
                    fact *= i;
                    i--;
                }
                return fact;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating Eulers number with the Taylor-series expansion around x0 = 0 within epsilon precision or n iterations at most.");
            int n;
            Console.Write("Number of iterations: n = ");
            int.TryParse(Console.ReadLine(), out n);

            double epsilon;
            Console.Write("Epsilon precision: epsilon = ");
            double.TryParse(Console.ReadLine(), out epsilon);

            int i = 0;
            double euler = 0;

            while (i < n)
            {
                double increment = 1.0 / (Fact(i));
                euler += increment;
                if (increment < epsilon)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine("The approximation of Eulers number: {0:G}", euler);
        }
    }
}
