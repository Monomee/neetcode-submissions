public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();
        // Dictionary<char, char> closeToOpen = new() {
        //     { ")", "(" },
        //     { "]", "[" },
        //     { "}", "{" }
        // }

        for(int i = 0; i < s.Length; i++){
            if (IsOpenBracket(s[i])) stk.Push(s[i]);
            else{
                if (stk.Count == 0) return false;

                if (s[i] == ')'){
                    if (stk.Pop() != '(') return false;
                } else if (s[i] == ']'){
                    if (stk.Pop() != '[') return false;
                } else if (s[i] == '}'){
                    if (stk.Pop() != '{') return false;
                }
            }
        }

        return stk.Count == 0;
    }

    public bool IsOpenBracket(char c){
        return (c == '(' || c == '[' || c == '{');
    }
}
