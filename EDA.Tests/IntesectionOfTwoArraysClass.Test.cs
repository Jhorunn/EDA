namespace EDA.Tests
{
    public class IntesectionOfTwoArraysClass
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] {2, 2})]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 9, 4 })]
        public void Intersect(int[] nums1, int[] nums2, int[] expected)
        {
            var result = EDALibrary.IntesectionOfTwoArraysClass.Intersect(nums1, nums2);
            Assert.Equal(expected, result);
        }
    }
}
