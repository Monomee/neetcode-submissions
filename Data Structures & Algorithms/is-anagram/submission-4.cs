public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> freq = new();
        for(int i = 0; i < s.Length; i++){
            if (!freq.ContainsKey(s[i]))
            {
                freq.Add(s[i], 1);
            }
            else
            {
                freq[s[i]]++;
            }
        }

        for (int j = 0; j < t.Length; j++){
            if (!freq.ContainsKey(t[j])) return false;
            freq[t[j]]--;
            if (freq[t[j]] == 0) freq.Remove(t[j]);
        }

        return freq.Count == 0;
    }
}
