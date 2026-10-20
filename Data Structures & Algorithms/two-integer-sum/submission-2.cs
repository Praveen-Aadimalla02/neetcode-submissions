public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int[] sum = new int[2];
        for(int i = 0; i < nums.Length ; i++)
        {

            if(dic.ContainsValue(target-nums[i]))
            {
                sum[0] = dic.FirstOrDefault(x => x.Value == target-nums[i]).Key;
                
                sum[1] = i;
            }
            else
            {
                dic[i] = nums[i];
            }
        }
        return sum;
    }
}
