namespace LeetCode.Array_and_String.Sliding_Window_Pattern;

public class LongestSubstringWithoutRepeatingCharacters_3
{
    int LengthOfLongestSubstring(string s) {
        if(s=="") return 0;
        if(s.Length ==1) return 1;
        var maxLen = 0;
        var start = 0;
        var end = 0;
        var set = new HashSet<char>();
        while(end <= s.Length-1){
            if(!set.Contains(s[end])){
                set.Add(s[end]);
                maxLen = Math.Max(maxLen, end - start + 1);
                end++;
            }else{
                set.Remove(s[start]);
                start++;
            }
        }
        return maxLen;
    }
    [Theory]
    [InlineData("au",  2)]
    [InlineData("abcabcbb", 3)]
    [InlineData("pwwkew", 3)]
    public void Test_1(string s, int expected){
        var res = LengthOfLongestSubstring(s);
        Assert.Equal(expected, res);
    }
    
}