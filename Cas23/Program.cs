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

            int[] numbers1 = new int[] { 1, 5, 9, 2, 6 };
            int max = FindLargestNum(numbers1);
            Console.WriteLine("1. Najveci u nizu je {0}", max);

            /*
             * Zadatak 2.
             * Razlika između najmanjeg i najvećeg broja
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati niz brojeva. Vratiti razliku između najvećeg
             * i najmanjeg broja.
             */

            int[] numbers2 = new int[] { -20, 16, 48, 5, -15, 2, 1, 9, 16, -43 };
            int diff = DiffMinMax(numbers2);
            Console.WriteLine("2. Razlika max-min je {0}", diff);

            /*
             * Zadatak 3.
             * Najduži string
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati niz stringova. Funkcija treba da vrati dužinu
             * najdužeg stringa. Funkciju treba napraviti u klasi Strings.
             */

            var niz = new string[] { "sto", "stolica", "prozor", "vrata", "neki jako dugacak string" };
            int x = Strings.FindLongest(niz);
            Console.WriteLine("3. Najduzi string ima duzinu od {0} karaktera.", x);

            /*
             * Zadatak 4.
             * Razlika među stringovima
             * 
             * Napisati funkciju koja će kao ulazne parametre
             * ima dva stringa. Funkcija treba da vrati broj razlika
             * između dva stringa. Napomena. Pretpostavimo da su oba
             * stringa iste dužine. Funkciju napraviti u klasi Strings.
             */

            var diff4 = Strings.NumDiffs("abcdefgh", "abecdfhh");
            Console.WriteLine("4. Broj razlika je {0}", diff4);


            /*
             * Zadatak 5.
             * Srednja (prosečna) vrednost
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati niz brojeva. Vratiti srednju vrednost brojeva.
             */
            var numbers = new int[] { 5, 6, 5, 6 };
            var prosek = GetAverage(numbers);
            Console.WriteLine("5. Srednja vrednost zadatih brojeva je {0}", prosek);

            /*
             * Zadatak 6.
             * Broj razmaka
             * 
             * Napisati funkciju koja će kao ulazni parametar
             * imati string. Vratiti broj razmaka (space) koji se
             * nalaze u stringu. String treba uzeti kao unos od
             * korisnika. Funkciju napisati u klasi Strings
             */
            Console.WriteLine("Unesi string (pritisni enter za kraj unosa)...");
            var unos = Console.ReadLine();
            var brojRazmaka = Strings.NumSpaces(unos);
            Console.WriteLine("6. Broj space karaktera u tvom stringu je: {0}", brojRazmaka);

            Console.ReadKey();
        }

        /*
         * Jos jedan nacin kako se moze proveriti da li je karakter
         * razmak (space), koriscenje char.IsWhiteSpace() metoda.
        */
        public static int Spejsovi(string rec)
        {
            int sum = 0;

            for (int i = 0; i < rec.Length; i++)
            {
                if (char.IsWhiteSpace(rec[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

        /*
         * Jos jedan od nacina, koriscenje Count() metoda koji
         * pripada objektima tipa string. Count uzima za parametar
         * koji tip karaktera brojimo, u nasem slucaju char.IsWhiteSpace
         */
        public static int Razmaci(string recenica)
        {
            return recenica.Count(char.IsWhiteSpace);
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

        public static int Prosec(params int[] niz)
        {
            int sum = 0;

            foreach (var item in niz)
            {
                sum += item;
            }

            return sum / niz.Length;
        }

        static int Avg(int[] niz)
        {
            int sum = 0;
            int a = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                sum = sum + niz[i];
                a = sum / niz.Length;
            }
            return a;

        }

        static double GetAverage(int[] numbers)
        {
            double zbir = 0;
            int ukupno = numbers.Length;
            for (var i = 0; i < numbers.Length; i++)
            {
                zbir += numbers[i];
            }
            double prosek = zbir / ukupno;
            return prosek;
        }

        public static int ProsecnaVrednost(params int[] nizBrojeva)
        {
            int sumaBrojeva = 0;

            foreach (int item in nizBrojeva)
            {
                sumaBrojeva += item;
            }

            return sumaBrojeva / nizBrojeva.Length;
        }
    }

}
