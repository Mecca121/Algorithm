using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithm.Test
{
    internal class Test3
    {

        public static class Kata
        {
            public static uint TrailingZeroes(uint n)
            {
                int m = Convert.ToInt32(n);
                string binary = Convert.ToString(m, 2);
                int result = 0;
                for (int i = binary.Length - 1; i < binary.Length; i--)
                {
                    if (binary[i] == '0')
                    {
                        result++;
                    }
                    else break;
                }
                return (uint)result;
            }
        }
    }
}
