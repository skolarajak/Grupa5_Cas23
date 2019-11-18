using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Zadatak 1.
             * 
             * Pronađi najveći broj u nizu             * Napisati funkciju koja će kao ulazni parametar
             * imati niz brojeva. Vratiti najveći broj iz niza.
             */

            //int[] numbers1 = new int[] { 1, 5, 9, 2, 6 };
            //int max = FindLargestNum(numbers1);
            //Console.WriteLine("1. Najveci u nizu je {0}", max);

            /*
             * Zadatak 2.
             * Razlika između najmanjeg i najvećeg broja
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati niz brojeva. Vratiti razliku između najvećeg
             * i najmanjeg broja.
             */

            //int[] numbers2 = new int[] { -20, 16, 48, 5, -15, 2, 1, 9, 16, -43 };
            //int diff = DiffMinMax(numbers2);
            //Console.WriteLine("2. Razlika max-min je {0}", diff);

            /*
             * Zadatak 3.
             * Najduži string
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati niz stringova. Funkcija treba da vrati dužinu
             * najdužeg stringa. Funkciju treba napraviti u klasi Strings.
             */

            //var niz = new string[] { "sto", "stolica", "prozor", "vrata", "neki jako dugacak string" };
            //int x = Strings.FindLongest(niz);
            //Console.WriteLine(x);

            /*
             * Zadatak 4.
             * Razlika među stringovima
             * 
             * Napisati funkciju koja će kao ulazne parametre
             * ima dva stringa. Funkcija treba da vrati broj razlika
             * između dva stringa. Napomena. Pretpostavimo da su oba
             * stringa iste dužine. Funkciju napraviti u klasi Strings.
             */

            var diff = Strings.NumDiffs("abcdefgh", "abecdfhh");
            Console.WriteLine("Broj razlika je {0}", diff);

            Console.ReadKey();
        }

        static int FindLargestNum(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        static int DiffMinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            int diff = max - min;
            return diff;
        }

    }
}
