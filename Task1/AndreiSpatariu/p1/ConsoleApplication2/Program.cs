using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Number
    {
        public int value;

        public void Declarare ()
        {
            value = Convert.ToInt32(Console.ReadLine());
        }

        public void Afisare ()
        {
            Console.WriteLine("Numarul este: {0}", value);
        }

        public void Conversie1(int n)
        {
            if (n == 1)
                Console.Write("o");

            else if (n == 2)
                Console.Write("doua");

            else  if (n == 3)
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
        }

        public void Conversie2(int n)
        {
            if (n == 1)
                Console.Write("unu");

            else if (n == 2)
                Console.Write("doi");

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
        }
        public void Conversie (int n)
        {
            if(n == 0)
            {
                Console.Write("zero");
            }

            else if (n < 10)
            {
                Conversie2(n);
            }

            else if(n == 10)
            {
                Console.Write("zece");
            }

            else if (n == 11)
            {
                Console.Write("unsprezece");
            }
            else if(n < 20)
            {
                Conversie2(n % 10);
                Console.Write("sprezece");
            }
            else if(n < 100 && n % 10 == 0) 
            {
                Conversie1(n / 10);
                Console.Write(" zeci ");
            }

            else if (n < 70 && n >= 60)
            {
                Console.Write("saizeci si ");
                Conversie2(n % 10);
            }
            else if(n < 100)
            {
                Conversie2(n / 10);
                Console.Write(" zeci si ");
                Conversie1(n % 10);
            }

            else if(n == 100)
            {
                Console.Write("o suta ");
            }

            else if(n < 1000)
            {
                Conversie1(n / 100);
                Console.Write(" sute ");
                if(n % 100 != 0)
                {
                    Conversie(n % 100);
                }
            }
        }
        public void ConversieFinala (int n)
        {
            if(n < 1000)
            {
                Conversie(n);
            }

            else if(n < 2000)
            {
                Console.Write("O mie ");
                if (n != 1000)
                {
                    Conversie(n % 1000);
                }
            }

            else if(n < 20000)
            {
                Conversie1(n / 1000);
                Console.Write(" mii ");
                if (n % 1000 != 0)
                {
                    Conversie(n % 1000);
                }
            }

            

            else if(n < 1000000)
            {
                Conversie(n / 1000);
                Console.Write(" de mii ");
                if (n % 1000 != 0)
                {
                    Conversie(n % 1000);
                }
            }
            
            else if (n == 1000000)
            {
                Console.Write("Un milion");
            }

            else if (n < 2000000)
            {
                Console.Write("Un milion ");
                ConversieFinala(n % 1000000);
            }

            else if(n < 5000000)
            {
                Conversie1(n / 1000000);
                Console.Write(" milioane ");
                ConversieFinala(n % 1000000);
            }

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Number nr = new Number();
            nr.Declarare();
            nr.Afisare();
            nr.ConversieFinala(nr.value);
            Console.ReadLine();
        }
    }
}
