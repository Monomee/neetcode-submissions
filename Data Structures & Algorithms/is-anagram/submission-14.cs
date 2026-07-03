public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] count = new int[256];
        for (int i = 0; i < s.Length; i++){
            count[s[i]] += 1;
            count[t[i]] -= 1;
        }

        for(int j = 0; j < count.Length; j++){
            if (count[j] != 0) return false;
        }

        return true;
    }
}
