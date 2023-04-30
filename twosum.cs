public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int[] tNums = {0,0};
        for(int i = 0; i <= nums.Length-1; i++)
        {
            for(int j = 0; j <= nums.Length-1; j++)
            {
                if(j!=i)
                {   
                    if(nums[j]+nums[i]==target)
                    {
                        tNums[0] = j;
                        tNums[1] = i;
                        j = nums.Length-1;
                        i = nums.Length-1;
                    }
                }     
            }
        }
        return tNums;
    }
}