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
                    if (data[i] * Math.Pow(10, Math.Floor(Math.Log10(data[i+1])) + 1) + data[i + 1] < data[i + 1] * Math.Pow(10, Math.Floor(Math.Log10(data[i])) + 1) + data[i])
                    {
                        exchange(data, i, i + 1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers;
            int i;

            Console.WriteLine("Cate numere vor fi introduse?");
            int n = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            Console.WriteLine("N este: {0}", n);
            for (i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Numarul cel mai mare este:");
            IntArrayBubbleSort(numbers);
            for (i = 0; i < 5; i++)
                Console.Write(numbers[i]);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}