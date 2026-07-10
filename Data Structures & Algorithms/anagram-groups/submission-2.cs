public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> group = new();

        for (int i = 0; i < strs.Length; i++){
            if (!group.ContainsKey(strs[i])){      
                bool exist = false;
                foreach(string key in group.Keys){
                    if (IsAnagram(key, strs[i])){
                        group[key].Add(strs[i]);
                        exist = true;
                        break;
                    }
                }      
                if (!exist) group.Add(strs[i], new List<string>());        
            }else{
                group[strs[i]].Add(strs[i]);
            }
            
        }

        List<List<string>> result = new();
        foreach (KeyValuePair<string, List<string>> kvp in group)
        {
            List<string> r = new();
            r.Add(kvp.Key);
            foreach (string s in kvp.Value) r.Add(s);
            result.Add(r);
        }

        return result;
    }

    public bool IsAnagram(string s1, string s2){
        if (s1.Length != s2.Length) return false;

        int[] s = new int[256];

        for (int i = 0; i < s1.Length; i++){
            s[s1[i]] += 1;
            s[s2[i]] -= 1;
        }
        for (int i = 0; i < s.Length; i++){
            if (s[i] != 0) return false;
        }

        return true;
    }
}
