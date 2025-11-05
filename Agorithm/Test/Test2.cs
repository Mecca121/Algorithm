using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agorithm.Test
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> waveList = new List<string>();
            if (string.IsNullOrEmpty(str))
            {
                return waveList;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                char[] charArray = str.ToCharArray();
                charArray[i] = char.ToUpper(charArray[i]);
                waveList.Add(new string(charArray));
            }
            return waveList;
        }
    }
}



