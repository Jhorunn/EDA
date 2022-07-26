namespace EDA.Tests
{
    public class FindTheDifferenceOfTwoArraysClass
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FindTheDifferenceOfTwoArraysFirstTry(int[] nums1, int[] nums2, List<IList<int>> expected)
        {
            var result = EDALibrary.FindTheDifferenceOfTwoArraysClass.FindTheDifferenceOfTwoArraysFirstTry(nums1, nums2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void FindTheDifferenceOfTwoArraysSecondTry(int[] nums1, int[] nums2, List<IList<int>> expected)
        {
            var result = EDALibrary.FindTheDifferenceOfTwoArraysClass.FindTheDifferenceOfTwoArraysSecondTry(nums1, nums2);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]{ new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 }, new List<IList<int>> { new List<int>{1, 3 }, new List<int> {4, 6 } } },
                new object[]{ new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2}, new List<IList<int>> { new List<int>{ 3 }, new List<int> {} } },               
            };

    }
}
