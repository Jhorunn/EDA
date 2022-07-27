using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDALibrary
{
    public class IntesectionOfTwoArraysClass
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();

            var result = new LinkedList<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if(dictionary.ContainsKey(nums1[i]))
                    dictionary[nums1[i]]++;
                else
                    dictionary.Add(nums1[i], 1);
            }

            for (int i = 0; i < nums2.Length; i++)
            {                

                if (dictionary.ContainsKey(nums2[i]) && dictionary[nums2[i]] > 0)
                {
                    result.AddLast(nums2[i]);
                    dictionary[nums2[i]]--;
                }
            }

            return result.ToArray();
        }
    }
}
