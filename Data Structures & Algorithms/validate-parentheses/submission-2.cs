public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();
        Dictionary<char, char> pairBracket = new() {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        for(int i = 0; i < s.Length; i++){
            if (pairBracket.ContainsKey(s[i])) stk.Push(s[i]);
            else if (stk.Count == 0 || s[i] != pairBracket[stk.Pop()]) return false;
        }

        return stk.Count == 0;
    }
}
