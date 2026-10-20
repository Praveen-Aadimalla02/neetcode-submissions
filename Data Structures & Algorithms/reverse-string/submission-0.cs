public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        char[] rev = new char[n];
        for(int i = n-1 ; i >= 0 ; i--)
        {
            rev[n-1-i] = s[i];
        }
        for(int i = 0 ; i < n ; i++)
        {
            s[i] = rev[i];
        }
    }
}