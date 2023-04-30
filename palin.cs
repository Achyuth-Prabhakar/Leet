public class Solution {
    public bool IsPalindrome(int number) {
        if(number<0) return false;
        int reversedNumber = 0;
        int original=number;
        while(number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }
        if(original == reversedNumber){
            return true;
        }
        return false;
    }
}