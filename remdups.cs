public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 1;
        int temp = nums[0];

        for (int i=1; i<nums.Length; i++) {
            if (nums[i] != temp) {
                nums[count] = nums[i];
                count++;
            }
            temp = nums[i];
        }

        return count;
    }
}