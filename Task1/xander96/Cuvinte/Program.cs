using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuvinte
{
    public static class StringExtension
    {
        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }
    class IN_LITERE
    {
        public static string NumberToWords(long number)
        {
            if (number == 0)
                return "";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                if ((number / 1000000000) == 1)
                {
                    words += NumberToWords(number / 10000000000) + " un miliard ";
                }
                else
                {

                    if ((number / 1000000000) == 2)
                        {
                            words += NumberToWords(number / 10000000000) + " doua miliarde ";
                        }
                    else
                        {
                            words += NumberToWords(number / 1000000000) + " de miliarde ";
                        }
                }
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                if ((number / 1000000) == 1)
                {
                    words += NumberToWords(number / 10000000) + " un milion ";
                }
                else
                {
                   if ((number / 1000000) == 2 )
                        {
                            words += NumberToWords(number / 10000000) + " doua milioane ";
                        }
                    else
                        {
                            words += NumberToWords(number / 1000000) + " de milioane ";
                        }
                }
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                if ((number / 1000) == 1)
                {
                    words += NumberToWords(number / 10000) + " o mie ";
                }
                else
                {

                    if ((number / 1000) == 2)
                        {
                            words += NumberToWords(number / 10000) + " doua mii ";
                        }
                    else
                        {
                            words += NumberToWords(number / 1000) + " de mii ";
                        }
                }

                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                if ((number / 100) == 1)
                {
                    words += NumberToWords(number / 1000) + " o suta ";
                }
                else
                {
                    if ((number / 100) == 2)
                    {
                        words += NumberToWords(number / 1000) + " doua sute ";
                    }
                    else
                    {
                        words += NumberToWords(number / 100) + " sute ";
                    }
                }
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";
                var units = new[] { "unu", "doua", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "zece" };
                var unitsMap = new[] { "unu", "doi", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "zece", "unspezece", "doisprezece", "treisprezece", "paisprezece", "cincisprezece", "saisprezece", "saptesprezece", "optsprezece", "nouasprezece" };
                var tensMap = new[] { "zero", "zece", "douazeci", "treizeci", "patruzeci", "cincizeci", "saizeci", "saptezeci", "optzeci", "nouazeci" };

                if (number < 20)
                    words += unitsMap[number - 1];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " si " + units[(number % 10) - 1];
                }
            }
            return words;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Urmeaza sa pronuntam numarul: ");
            long numar=Convert.ToInt64(Console.ReadLine());
            Console.Write("Numarul dorit este: ");
            Regex trimmer = new Regex(@"\s\s+");
            string s = trimmer.Replace(IN_LITERE.NumberToWords(numar), " ");
            string res = s.GetLast(4);
            if (string.Compare(res, "doua") == 0)
            {
                s = s.Substring(0, s.Length - 2) + "i";
            }
            Console.WriteLine(s.ToUpper());
            Console.WriteLine("Este numarul dorit, nu-i asa? ");
            Console.ReadLine();
        }
    }
}
