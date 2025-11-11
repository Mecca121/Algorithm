using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Class2
{
    public class Kata
    {
        public static bool IsAnagram(string a, string b)
        {
            Char[] FirstArray = a.ToLower().ToArray();
            Char[] SecondArray = b.ToLower().ToArray();

            Array.Sort(FirstArray);
            Array.Sort(SecondArray);

            String Mecca = new String(FirstArray);
            String Gadget = new String(SecondArray);


            if (Mecca == Gadget)
            {
                return true;
            }
            else return false;
        }
    }
}



