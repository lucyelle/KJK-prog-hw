using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the resultant resistance from resistors connected in series (S) or parallel (P).");
            char input;
            
            do
            {
                Console.WriteLine("S / P: ");
                input = char.ToUpper(Console.ReadLine()[0]);
            }
            while (input != 'S' && input != 'P');

            double R = 1;
            int i = 1;

            if (input == 'S')
            {
                double S_resultant = 0;
                while (R > 0)
                {
                    Console.Write("R(" + i + ") = ");
                    double.TryParse(Console.ReadLine(), out R);
                    if (R > 0)
                    {
                        S_resultant += R;
                    }
                    i++;
                }
                Console.WriteLine("Resultant resistance: R(S) = {0:G}", S_resultant);
            }

            else
            {
                double P_resultant_r = 0;
                while (R > 0)
                {
                    Console.Write("R(" + i + ") = ");
                    double.TryParse(Console.ReadLine(), out R);
                    if (R > 0)
                    {
                        P_resultant_r += 1 / R;
                    }
                    i++;
                }
                double P_resultant = 1 / P_resultant_r;
                Console.WriteLine("Resultant resistance: R(P) = {0:G}", P_resultant);
            }
        }
    }
}
