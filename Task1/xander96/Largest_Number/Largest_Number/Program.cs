using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number{
    //In order to sort the numbers properly for their usefull digits we need a special representation
    //So we are bringing the numbers to the same lenght
    //For ex. if the numbers are 98 9 976, they will become 989 999 976, so the correct order is 9,98,976
    class Help
    {
        public static int correct_number(int x, int digits)
        {
            int correct = new int();
            correct = x * ((int)(Math.Pow(10, digits - ((int)Math.Floor(Math.Log10(x) + 1)))));
            for (int i = 0; i < (digits - ((int)Math.Floor(Math.Log10(x) + 1))); i++ )
            {
                correct += 9 * (int)(Math.Pow(10, i));
            }
            return correct;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to read from input.txt ( The FILE must be in the Debug Folder! )");
            string fileContent = File.ReadAllText("input.txt");
            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' , ',' , ';' , ':', '\'', '\"' , '[' , '(' , '{' , ']', ')', '}' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[integerStrings.Length];
            for (int n = 0; n < integerStrings.Length; n++)
                numbers[n] = int.Parse(integerStrings[n]);
            //Checking if the reading is good
            /*foreach(int i in numbers)
            {
                Console.WriteLine("{0}", i);
            }*/
            int max_digits = new int();
            int aux =  new int();
            max_digits = 0;
            foreach(int i in numbers)
            {
                if ( max_digits < Math.Floor(Math.Log10(i) + 1) )
                {
                    max_digits = (int)Math.Floor(Math.Log10(i) + 1);
                }
                if ( max_digits == 5 )
                {
                    break;
                }
            }
            //See the max number of digits
            //Console.WriteLine("{0}", max_digits);
            //Sorting the Array so we can build the number
            bool ok = true;
            while ( ok )
            {
                ok = false;
                for (int i = 0; i < ( numbers.Length - 1 ) ; i++)
                { 
                    if ( Help.correct_number(numbers[i],max_digits) < Help.correct_number(numbers[i+1], max_digits))
                    {
                        ok = true;
                        aux = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = aux;
                    }
                }
            }
            Console.Write("Biggest number that can be built is: ");
            foreach(int i in numbers)
            {
                Console.Write("{0}", i);
            }
            Console.Read();
         }
    }
}
