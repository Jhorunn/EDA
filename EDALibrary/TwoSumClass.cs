namespace EDALibrary
{
    public class TwoSumClass
    {
        public static int[] TwoSumFirst(int[] nums, int target)
        {
            var dictionary = nums
                .Select((v, i) => new { Key = i, Value = v })
                .ToDictionary(o => o.Key, o => o.Value);


            for (int i = 0; i <= nums.Length; i++)
            {
                int k = dictionary.FirstOrDefault(x => x.Value == (target - nums[i]) && x.Key != i).Key;

                if (dictionary.ContainsKey(k) && k > 0)
                    return new int[] { i, k };
                else
                    continue;
            }

            return new int[] {};
        }

        public static int[] TwoSumSecond(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            int auxiliar;
            for(int i = 1; i < nums.Length; i++)
            {
                auxiliar = target - nums[i];
                dictionary.TryAdd(nums[i - 1], i - 1);
                if(dictionary.ContainsKey(auxiliar))
                {
                    return new int[] { dictionary[auxiliar], i };
                }

            }
            return new int[]{ };
        }
    }
}