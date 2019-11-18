using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas23
{
    class Strings
    {
        public static int FindLongest(string[] strings)
        {
            var element = strings[0];
            var maxDuzina = element.Length;
            for (var i = 1; i < strings.Length; i++)
            {
                element = strings[i];
                if (maxDuzina < element.Length)
                {
                    maxDuzina = element.Length;
                }
            }

            return maxDuzina;
        }

        public static int NumDiffs(string prvi, string drugi)
        {
            var brRazlika = 0;
            for (var i = 0; i < prvi.Length; i++)
            {
                if (prvi[i] != drugi[i])
                {
                    brRazlika++;
                }
            }

            return brRazlika;
        }

        internal static int NumSpaces(string unos)
        {
            var brojRazmaka = 0;
            for (var i = 0; i < unos.Length; i++)
            {
                if (unos[i] == ' ')
                {
                    brojRazmaka++;
                }
            }
            return brojRazmaka;
        }
    }
}