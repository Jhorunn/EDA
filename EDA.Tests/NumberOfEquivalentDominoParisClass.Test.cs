using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Tests
{
    public class NumberOfEquivalentDominoParisClass
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void NumEquivDominoPairs(int[][] dominoes, int expected)
        {
            var result = EDALibrary.NumberOfEquivalentDominoParisClass.NumEquivDominoPairs(dominoes);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, 1 },
                new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 1, 1 }, new int[] { 1, 2 }, new int[] { 2, 2 } }, 3 }
            };
    }
}
