using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify the elements of the array (int): ");
            int[] array = ReadIn(n);
            int min = Min(array, out int minIndex);
            int max = Max(array, out int maxIndex);

            Console.WriteLine("Max element of array: " + max);
            Console.WriteLine("Index: " + maxIndex);

            Console.WriteLine("Min element of array: " + min);
            Console.WriteLine("Index: " + minIndex);
        }

        static int[] ReadIn(int n)
        {
            int[] read = new int[n];
            for (int i = 0; i < n; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                read[i] = elem;
            }
            return read;
        }

        static int Max(int[] array, out int index)
        {
            int max = array[0];
            index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return max;
        }

        static int Min(int[] array, out int index)
        {
            int min = array[0];
            index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return min;
        }
    }
}
