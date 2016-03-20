using System;
using System.Collections.Generic;
using System.Text;

namespace Problema2
{
    class ProgramPrinc
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int i;
            bool ok = false;
            char y = 'y';

            while (y == 'y')
            {
                Console.WriteLine("Cate numere vor fi introduse?");
                int n = Convert.ToInt32(Console.ReadLine());
                numbers = new int[n];
                Console.WriteLine("Introduceti cate un numar pe linie:");

                for (i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                    if (numbers[i] != 0)  //Trateaza cazul in care toate numerele din vector sunt 0
                    {
                        ok = true;
                    }
                }

                Console.WriteLine("Numarul cel mai mare este:");
                Sortare.Sort(numbers);

                if (ok)
                {
                    for (i = 0; i < n; i++)
                    {
                        Console.Write(numbers[i]);
                    }
                }
                else
                {
                    Console.Write("0");
                }

            Console.WriteLine();
            Console.WriteLine("Doriti sa incercati alt numar? (y/n) Apasati doar key-ul, nu dati enter");
            y = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

    }
    }
}