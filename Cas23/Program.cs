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
            int[] numbers = new int[] { 10, 5, 9, 2, 6 };
            int max = FindLargestNum(numbers);
            Console.WriteLine("Najveci u nizu je {0}", max);
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
    }
}
