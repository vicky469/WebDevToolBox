namespace LeetCode.Recursion;

public class ReverseAString:TestBase
{
    static string ReverseString(string str)
    {
        if (str.Length == 1)
        {
            Console.WriteLine("========= start to return =========");
            return str;
        }
        var head = str.Substring(0,1);
        var tail =  str.Substring(1,str.Length-1);
        Console.WriteLine($"head: {head}");
        Console.WriteLine($"tail: {tail}");
        var res =  ReverseString(tail)+head;
        Console.WriteLine($"return: {res}");
        return res;
    }
    
    [Theory]
    [InlineData("cat", "tac")]
    private void Test_OK(string input, string expectedResult)
    {
        var res = ReverseString(input);
        Assert.Equal(expectedResult, res);
    }

    public ReverseAString(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}