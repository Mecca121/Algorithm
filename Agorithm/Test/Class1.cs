using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithm.Test
{
    internal class Class1
    {
        public class Kata
        {
            public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
            {
                TimeSpan difference = endDate - startDate;
                return (int)difference.TotalSeconds;
            }
        }
    }
}
