using LeetCode.Util;

namespace LeetCode.Stack;

public class ValidParentheses_20
{
    // An input string is valid if:
    //     1. Open brackets must be closed by the same type of brackets.
    //     2. Open brackets must be closed in the correct order.
    //     3. Every close bracket has a corresponding open bracket of the same type.
    // Constraints: s consists of parentheses only '()[]{}'.
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        var partsMapping = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        var parts = s.Select(c=>c).ToArray();
        var stack = new Stack<char>();
        for(var i = 0; i < parts.Length; i++)
        {
            // If c is an opening bracket
            if(partsMapping.ContainsKey(parts[i]))
            {
                stack.Push(parts[i]);
            }
            else
            {
                // If c is a closing bracket
                if(stack.Count == 0) return false;
                
                var open = stack.Pop();
                if(parts[i] != partsMapping[open]) return false;
            }
        }

        if (stack.Count > 0) return false;
        return true;
    }
    
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void IsValidTest(string input, bool expected)
    {
        var result = IsValid(input);
        Assert.Equal(expected, result);
    }
}