using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class Sortare
    {
        public static void exchange(int[] intArray, int m, int n)
        {
            int temporary;

            temporary = intArray[m];
            intArray[m] = intArray[n];
            intArray[n] = temporary;
        }

        public static void Sort(int[] intArray)
        {
            int i, j;
            int N =
                intArray.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    //Creez un numar nou format prin lipirea lui intArray[i] si intArray[i+1]
                    double left = intArray[i] * Math.Pow(10, Math.Floor(Math.Log10(intArray[i + 1])) + 1) + intArray[i + 1];

                    //Creez un numar nou format prin lipirea lui intArray[i+1] si intArray[i]
                    double right = intArray[i + 1] * Math.Pow(10, Math.Floor(Math.Log10(intArray[i])) + 1) + intArray[i];

                    if (intArray[i] == 0 && intArray[i + 1] == 0) //Formulele de mai sus au probleme cand una din variabile este 0
                    {                                          //deoarece nu pot calcula logaritm(0), asa ca este tratat ca un caz special
                        left = right;
                    }

                    else if (intArray[i] == 0)
                    {
                        left = 0;
                        right = 1;
                    }

                    else if (intArray[i + 1] == 0)
                    {
                        right = -1;
                    }


                    if (left < right)
                    {
                        exchange(intArray, i, i + 1);
                    }
                }
            }
        }
    }
}
