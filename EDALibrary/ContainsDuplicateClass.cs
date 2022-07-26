using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDALibrary
{
    public class ContainsDuplicateClass
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var hasSet = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                hasSet.Add(nums[i]);
                if (hasSet.Contains(nums[i + 1]))
                    return true;
            }
            return false;
        }
    }
}
