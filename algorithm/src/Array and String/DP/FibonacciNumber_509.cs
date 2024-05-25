using System.Linq;

namespace LeetCode.Recursion.DP;

public class FibonacciNumber_509
{
    private static int[] mem = new int [30];
    static int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (!mem.Contains(n)) mem[n] = Fib(n - 1) + Fib(n - 2);
        return mem[n];
    }
    
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    private void Test_OK(int n, int expectedResult)
    {
        var result = Fib(n);
        Assert.Equal(expectedResult, result);
    }
    
}