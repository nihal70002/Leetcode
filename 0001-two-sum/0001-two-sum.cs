public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        // This will never be reached according to problem statement,
        // but needed to satisfy the compiler
        throw new ArgumentException("No two sum solution");
    }
}
