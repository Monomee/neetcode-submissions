
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new();

        foreach (int n in nums){
            if (dup.Contains(n)) return true;
            else dup.Add(n);
        }

        return false;
    }
}