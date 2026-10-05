public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> duplicates = new Dictionary<int,int>();
        for(int i=0 ; i < nums.Length; i++)
        {
            if(!duplicates.ContainsKey(nums[i]))
            {
                duplicates[nums[i]] = 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}