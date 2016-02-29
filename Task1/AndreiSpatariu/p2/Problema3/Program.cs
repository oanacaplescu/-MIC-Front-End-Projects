using System;
using System.Collections.Generic;
using System.Text;

namespace Problema2
{
    class Program
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j, clona1, clona2;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    clona1 = data[i];
                    clona2 = data[i + 1];
                    if (data[i] * Math.Pow(10, Math.Floor(Math.Log10(clona2)) + 1) + data[i + 1] < data[i + 1] * Math.Pow(10, Math.Floor(Math.Log10(clona1)) + 1) + data[i])
                    {
                        exchange(data, i, i + 1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 30, 99, 4352, 34 };
            int len = 5;

            Console.WriteLine("Numarul cel mai mare este:");
            IntArrayBubbleSort(numbers);
            for (int i = 0; i < 5; i++)
                Console.Write(numbers[i]);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}