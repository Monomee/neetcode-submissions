public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        int mid;

        while (low <= high){
            mid = (int)(low + (high - low) * 0.5f);

            if (nums[mid] == target) return mid;
            
            if (nums[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }
}
