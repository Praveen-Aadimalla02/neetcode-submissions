public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sum = new int[2];
        for(int i = 0; i < nums.Length-1 ; i++)
        {
            for(int j = i+1 ; j < nums.Length ; j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    sum[0] = i;
                    sum[1] = j;
                }
            }
        }
        return sum;
    }
}
