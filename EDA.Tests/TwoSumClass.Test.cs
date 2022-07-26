using EDALibrary;

namespace EDA.Tests
{
    public class TwoSumClass
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] {0, 1})]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumFirst(int[] nums, int target, int[] expected)
        {
            var result = EDALibrary.TwoSumClass.TwoSumFirst(nums, target);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumSecond(int[] nums, int target, int[] expected)
        {
            var result = EDALibrary.TwoSumClass.TwoSumSecond(nums, target);
            Assert.Equal(expected, result);
        }
    }
}