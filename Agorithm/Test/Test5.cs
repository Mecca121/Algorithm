using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithm.Test
{
    internal class Test5
    {
        public static double FindAverage(double[] array)
        {
            if (array == null)
                return 0;
            else return array.Average();
        }
    }
}
