using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDALibrary
{
    public class NumberOfEquivalentDominoParisClass
    {

        public static int NumEquivDominoPairs(int[][] dominoes)
        {
            var dict = new Dictionary<int, int>();
            int result = 0;
            int a, b, hash;

            for (int i = 0; i < dominoes.Length; i++)
            {
                a = dominoes[i][0];
                b = dominoes[i][1];

                hash = a <= b ? (10 * a + b) : (10 * b + a);

                if (dict.ContainsKey(hash))                
                    dict[hash] ++;                
                else                
                    dict.Add(hash, 0);
                
                result += dict[hash];
            }
            return result;
        }
    }
}
