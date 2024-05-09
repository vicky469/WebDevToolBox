using System.Collections.Generic;

namespace LeetCode.array_and_string.String;

public class ValidAnagram_242
{
    static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;
        var dict = new Dictionary<char,int>(); //char:cnt
        foreach (var ch in s1)
        {
            if (!dict.ContainsKey(ch))
            {
                dict.Add(ch,1);
            }
            else
            {
                dict[ch]++;
            }
        }

        foreach (var ch in s2)
        {
            if (!dict.ContainsKey(ch) || dict[ch] == 0) return false;
            dict[ch]--;
        }

        return true;
    }
    
    
    [Theory]
    [InlineData( "anagram", "nagaram",true)]
    [InlineData( " ", " ",true)]
    [InlineData( "ac",  "a",false)]
    private void Test_OK(string s1, string s2, bool expectedResult)
    {
        var result = IsAnagram(s1,s2);
        Assert.Equal(expectedResult, result);
    }
}