public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> remain = new();
        
        for (int i = 0; i < nums.Length; i++){
            if (remain.TryGetValue(target - nums[i], out int index)) {
                return new int[] { index, i };
            }
            if (!remain.ContainsKey(nums[i])){
                remain.Add(nums[i], i);
            }
        }

        return null;
    }
}
