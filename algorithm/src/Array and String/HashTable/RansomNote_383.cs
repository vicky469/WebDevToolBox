namespace LeetCode.Array_and_String.HashTable;

public class RansomNote_383
{
    bool CanConstruct(string ransomNote, string magazine) {
        // create a dictionary to store the frequency of each character in magazine
        var dict = new Dictionary<char, int>();
        foreach (var c in magazine)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach (var c in ransomNote)
        {
            if (dict.ContainsKey(c))
            {
                var count = dict[c];
                if(count == 0) return false;
                dict[c] -= 1;
            }else{
                return false;
            }
        }
        return true;
    }
    
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void Test(string ransomNote, string magazine, bool expected)
    {
        Assert.Equal(expected, CanConstruct(ransomNote, magazine));
    }
    
}