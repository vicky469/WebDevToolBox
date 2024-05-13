using LeetCode.Util;

namespace LeetCode.Recursion.Stack;

public class ValidParentheses_20
{
    // An input string is valid if:
    //     1. Open brackets must be closed by the same type of brackets.
    //     2. Open brackets must be closed in the correct order.
    //     3. Every close bracket has a corresponding open bracket of the same type.
    // Constraints: s consists of parentheses only '()[]{}'.
    
    //TODO: WRONG IMPLEMENTATION, come back later
    public bool IsValid(string s) {
        var partsMapping = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Length % 2 != 0) return false;
        if (partsMapping.ContainsValue(s[0])) return false;

        var closingBracket = partsMapping[s[0]];
        var closingBracketIndex = s.LastIndexOf(closingBracket);
        if (closingBracketIndex == -1) return false;
        
        string remainingString;
        if (closingBracketIndex == s.Length - 1)
        {
            remainingString = s.Substring(1, closingBracketIndex - 1);
        }
        else
        {
            remainingString = s.Substring(closingBracketIndex + 1);
        }

        return IsValid(remainingString);
    }
    
    
    [Theory]
    // [InlineData("()", true)]
     [InlineData("(){}{}", true)]
    // [InlineData("(]", false)]
    // [InlineData("([)]", false)]
    // [InlineData("{[]}", true)]
    // [InlineData("((", false)]
    [InlineData("(([]){})", true)]
    public void IsValidTest(string input, bool expected)
    {
        var res2 = IsValid(input);
        Assert.Equal(expected, res2);
    }
}