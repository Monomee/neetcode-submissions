public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        
        int i = 0;
        int j = s.Length - 1;

        while(i <= j){
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }

            if (s[i] != s[j]) {
                return false; 
            } else{
                i++;
                j--;
            }
        }

        return true;
    }
}
