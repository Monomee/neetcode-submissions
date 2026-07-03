public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> remain = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            if (remain.ContainsKey(target - nums[i])){
                return new int[] {remain[target - nums[i]], i};            
            } 
            if (!remain.ContainsKey(nums[i])){
                remain.Add(nums[i], i);
            }                    
        }

        return null;
    }
}
