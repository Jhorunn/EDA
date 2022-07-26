using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDALibrary
{
    public class FindTheDifferenceOfTwoArraysClass
    {
        // First Try
        public static IList<IList<int>> FindTheDifferenceOfTwoArraysFirstTry(int[] nums1, int[] nums2)
        {
            var hahsSet = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (hahsSet.Contains(nums1[i]))
                    continue;

                for (int j = 0; j < nums2.Length; j++)
                {
                    if (hahsSet.Contains(nums2[j]))
                        continue;
                    if (nums1[i] == nums2[j])
                        hahsSet.Add(nums1[i]);
                }
            }
            var result1 = nums1.Where(x => !hahsSet.Contains(x)).Distinct().ToList();
            var result2 = nums2.Where(x => !hahsSet.Contains(x)).Distinct().ToList();
            return new List<IList<int>> { result1, result2 };
        }

        public static IList<IList<int>> FindTheDifferenceOfTwoArraysSecondTry(int[] nums1, int[] nums2)
        {
            var hashSet1 = new HashSet<int>();
            var hashSet2 = new HashSet<int>();
            var hashSetAuxiliar = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if(!hashSet1.Contains(nums1[i]))
                    hashSet1.Add(nums1[i]);
            }

            for(int i = 0; i < nums2.Length; i++)
            {
                if (!hashSet2.Contains(nums2[i]) && !hashSetAuxiliar.Contains(nums2[i]))
                    hashSet2.Add(nums2[i]);

                if (hashSet1.Contains(nums2[i]))
                {
                    hashSet1.Remove(nums2[i]);
                    hashSet2.Remove(nums2[i]);
                    hashSetAuxiliar.Add(nums2[i]);
                }
            }

            return new List<IList<int>> { hashSet1.ToList(), hashSet2.ToList() };
        }
    }
}
