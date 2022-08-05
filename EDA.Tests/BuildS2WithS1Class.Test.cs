using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Tests
{
    public class BuildS2WithS1Class
    {
        [Theory]
        [InlineData("abcda", "aaa", false)]
        [InlineData("abcda", "abb", false)]
        [InlineData("abcda", "aabd", true)]
        public void BuildS2WithS1(string s1, string s2, bool expected)
        {
            var result = EDALibrary.BuildS2WithS1Class.BuildS2WithS1(s1, s2);
            Assert.Equal(expected, result);
        }
    }
}
