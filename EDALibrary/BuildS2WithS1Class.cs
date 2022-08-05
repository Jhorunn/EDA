using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDALibrary
{
    public  class BuildS2WithS1Class
    {
        public static bool BuildS2WithS1(string s1, string s2)
        {
            var hashS1 = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (hashS1.ContainsKey(s1[i]))
                    hashS1[s1[i]]++;
                else
                    hashS1.Add(s1[i], 1);
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (hashS1.ContainsKey(s2[i]) && hashS1[s2[i]] > 0)
                {
                    hashS1[s2[i]]--;
                }
                else
                    return false;
                    
            }
            return true;
        }
    }
}
