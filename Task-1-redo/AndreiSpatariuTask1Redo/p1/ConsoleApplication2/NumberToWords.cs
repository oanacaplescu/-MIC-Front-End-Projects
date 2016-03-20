using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class NumberToWords
    {
        public int NumericalValue;  //Valoarea numerica a numarului ce urmeaza sa fie transformat

        public void Declare()
        {
            NumericalValue = Convert.ToInt32(Console.ReadLine());
        }

        public void NumToWordF(int n)
        {
            if (n == 1)
                Console.Write("o");

            else if (n == 2)
                Console.Write("doua");

            else if (n == 3)
                Console.Write("trei");

            else if (n == 4)
                Console.Write("patru");

            else if (n == 5)
                Console.Write("cinci");

            else if (n == 6)
                Console.Write("sase");

            else if (n == 7)
                Console.Write("sapte");

            else if (n == 8)
                Console.Write("opt");

            else if (n == 9)
                Console.Write("noua");
        }  //Se ocupa de numere < 10 cu varianta feminina pentru 1 si 2

        public void NumToWordM(int n)
        {
            if (n == 1)
                Console.Write("unu");

            else if (n == 2)
                Console.Write("doi");

            else if (n > 2 && n < 10)
                NumToWordF(n);
        }   //Se ocupa de numere < 10 cu varianta masculina pentru 1 si 2

        public void NumToWordsHundreds(int n)
        {
            if (n == 0)
            {
                Console.Write("zero");
            }

            else if (n < 10)
            {
                NumToWordM(n);
            }

            else if (n == 10)
            {
                Console.Write("zece");
            }

            else if (n == 11)
            {
                Console.Write("unsprezece");
            }
            else if (n < 20)
            {
                NumToWordF(n % 10);
                Console.Write("sprezece");
            }
            else if (n < 100 && n % 10 == 0)
            {
                NumToWordF(n / 10);
                Console.Write(" zeci ");
            }

            else if (n < 70 && n >= 60)
            {
                Console.Write("saizeci si ");
                NumToWordM(n % 10);
            }
            else if (n < 100)
            {
                NumToWordF(n / 10);
                Console.Write(" zeci si ");
                NumToWordM(n % 10);
            }

            else if (n == 100)
            {
                Console.Write("o suta ");
            }

            else if (n < 200)
            {
                Console.Write("o suta ");
                NumToWordsHundreds(n % 100);
            }

            else if (n < 1000)
            {
                NumToWordF(n / 100);
                Console.Write(" sute ");
                if (n % 100 != 0)
                {
                    NumToWordsHundreds(n % 100);
                }
            }
        } //Se ocupa de numere < 1000 

        public void NumToWordsThousands(int n)
        {
            if (n < 1000)
            {
                NumToWordsHundreds(n);
            }

            else if (n < 2000)
            {
                Console.Write("O mie ");
                if (n != 1000)
                {
                    NumToWordsHundreds(n % 1000);
                }
            }

            else if (n < 20000)
            {
                NumToWordsHundreds(n / 1000);
                Console.Write(" mii ");
                if (n % 1000 != 0)
                {
                    NumToWordsHundreds(n % 1000);
                }
            }



            else if (n < 1000000)
            {
                NumToWordsHundreds(n / 1000);
                Console.Write(" de mii ");
                if (n % 1000 != 0)
                {
                    NumToWordsHundreds(n % 1000);
                }
            }

            else if (n == 1000000)
            {
                Console.Write("Un milion");
            }

            else if (n < 2000000)
            {
                Console.Write("Un milion ");
                NumToWordsThousands(n % 1000000);
            }

            else if (n < 5000000)
            {
                NumToWordF(n / 1000000);
                Console.Write(" milioane ");
                NumToWordsThousands(n % 1000000);
            }

        } //Se ocupa de restul numerelor, pana la limita maxima acceptata
    }
}
