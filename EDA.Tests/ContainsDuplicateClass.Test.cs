﻿

namespace EDA.Tests
{
    public class ContainsDuplicateClass
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicate(int[] nums, bool expected)
        {
            var result = EDALibrary.ContainsDuplicateClass.ContainsDuplicate(nums);
            Assert.Equal(expected, result);
        }
    }
}
