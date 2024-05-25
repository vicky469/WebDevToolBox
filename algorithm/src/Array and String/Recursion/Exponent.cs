namespace LeetCode.Recursion.Array_and_String;

public class Exponent
{
    private static int res = 1;
    static int ExponentRecursion(int a, int n) //a = base, n = exponent
    {
        //base case:
        if (n == 1) return a;
        //recursive case when odd:
        if (n % 2 != 0)
        {
            res = ExponentRecursion(a, n / 2);
            return res * res * a;
        }else if (n % 2 == 0)// recursive case when even:
        {
            res = ExponentRecursion(a, n / 2);
            return res * res;
        }
        return res;
    }
    
    
    static int ExponentStack(int a, int n) //a = base, n = exponent
    {
        if (n == 1) return a;
        var opStack = new Stack<string>();
        var res = a;
        // 1. create the stack, each frame has the operation it needs to perform 
        while (n > 1)
        {
            if (n % 2 != 0) //odd
            {
                n -= 1;
                opStack.Push("multiply");
            }else if (n % 2 == 0) //even
            {
                n /= 2;
                opStack.Push("square");
            }
        }
        // 2. perform the operation in reverse order
        while(opStack.Count > 0)
        {
            var val = opStack.Pop();
            if (val == "multiply")
            {
                res *= a;
            }else if (val== "square")
            {
                res *= res;
            }
        }
        return res;
    }
    
    
    [Theory]
    [InlineData(3, 6, 729)]
    [InlineData(3,5,243)]
    //[InlineData(3,3,27)]
    // [InlineData(0,1,0)]
    // [InlineData(1,0,1)]
    private void Test_OK(int a, int n, int expectedResult)
    {
        //var result = ExponentRecursion(a, n);
        //Assert.Equal(expectedResult, result);
        
        var res2 = ExponentStack(a, n);
        Assert.Equal(expectedResult, res2);
    }
}