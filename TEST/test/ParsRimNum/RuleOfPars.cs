using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsRimNum
{
    internal class RuleOfPars
    {
        //II
        //IV
        //XIV = 10 - 1 + 5 = 14
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50},
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 },
        };
        public static int Parse(string roman)
        {
            int result = 0;
            for(int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubstractive(roman[i], roman[i + 1]))
                {

                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }
            }
            return result;
        }

        private static bool IsSubstractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}
