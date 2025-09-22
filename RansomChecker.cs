using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._1._1
{
    public class RansomChecker
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> charcount = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (charcount.ContainsKey(c))
                {
                    charcount[c]++;
                }
                else
                {
                    charcount[c] = 1;
                }
            }

            foreach (char c in ransomNote)
            {
                if (!charcount.ContainsKey(c) || charcount[c] == 0)
                {
                    return false;
                }
                charcount[c]--;
            }
            return true;
        }
    }
}
