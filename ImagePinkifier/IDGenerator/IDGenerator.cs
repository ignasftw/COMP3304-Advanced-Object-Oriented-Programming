using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGenerator
{
    public static class IDGenerator
    {
        private static readonly char[] consonants = {
            'b',
            'c',
            'd',
            'f',
            'g',
            'h',
            'j',
            'l',
            'm',
            'n',
            'p',
            'q',
            'r',
            's',
            't',
            'v',
            'w',
            'y',
            'z',
        };
        private static readonly char[] vowels =
        {
            'a',
            'e',
            'i',
            'o',
            'u',
            'y'
        };

        private static readonly Random random = new Random();

        public static string RandomPhoneme()
        {
            string returnString = "";

            returnString += consonants[random.Next(consonants.Length)];
            returnString += vowels[random.Next(vowels.Length)];

            return returnString;
        }
    }
}
