public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 0) return false;
        HashSet<int> checkList = new HashSet<int>();
        checkList.Add(nums[0]);
        for (int i = 1; i < nums.Length; i++){
            if (checkList.Contains(nums[i])) return true;
            checkList.Add(nums[i]);
        }
        return false;
    }
}