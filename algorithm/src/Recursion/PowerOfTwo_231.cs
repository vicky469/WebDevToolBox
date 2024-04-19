namespace LeetCode.Recursion;
// https://leetcode.com/problems/power-of-two/description/
public class PowerOfTwo_231
{
    //n == 2^x
    static bool IsPowerOfTwo(int n)
    {
        if (n == 1) return true;
        if (n == 0) return false;
        if (n % 2 == 0) //even
        {
            return IsPowerOfTwo(n / 2);
        }
        return false;
    }
    [Theory]
    [InlineData(1, true)]
    [InlineData(3,false)]
    [InlineData(16,true)]
    private void Test_OK(int n, bool expectedResult)
    {
        var res = IsPowerOfTwo(n);
        Assert.Equal(expectedResult, res);
    }
}