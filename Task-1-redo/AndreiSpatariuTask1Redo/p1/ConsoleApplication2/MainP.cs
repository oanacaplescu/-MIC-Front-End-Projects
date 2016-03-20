using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MainP
    {
        static void Main(string[] args)
        {
            NumberToWords nr = new NumberToWords();
            char y = 'y';
            while (y == 'y')
            {
                Console.Write("Introduceti numarul care doriti sa fie convertit->");
                nr.Declare();
                Console.WriteLine("Numarul convertit este");
                nr.NumToWordsThousands(nr.NumericalValue);
                Console.WriteLine();
                Console.WriteLine("Doriti sa incercati alt numar? (y/n) Apasati doar key-ul, nu dati enter");
                y = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
    }
    
}
