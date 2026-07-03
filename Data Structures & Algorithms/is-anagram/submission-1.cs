public class Solution {
    public void AddToDictionary(Dictionary<char, int> freq, string str){
        str = str.ToLower();
        for (int i = 0; i < str.Length; i++){
            if (!freq.ContainsKey(str[i]))
            {
                freq.Add(str[i], 1);
            }
            else
            {
                freq[str[i]]++;
            }
        }
    }
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> freqS = new Dictionary<char, int>();
        Dictionary<char, int> freqT = new Dictionary<char, int>();

        AddToDictionary(freqS, s);
        AddToDictionary(freqT, t);

        if (freqS.Count != freqT.Count) return false;

        foreach(var key in freqS.Keys){
            if (!freqT.ContainsKey(key)) return false;
            if (freqS[key] != freqT[key]) return false;
        }

        return true;
    }
}
