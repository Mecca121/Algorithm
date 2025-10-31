using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithm
{
    internal class Class5
    {
        public static char GetCharIndex(string name, int num)
        {
            if (num >= name.Length || num < 0)
            {
                return 'A';
            }
            else
            {
                return name[num];
            }
        }
    }
}
