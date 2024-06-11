namespace LeetCode.Array_and_String.HashSet;

public class HappyNumber_202
{
    bool IsHappy(int n) {
        var set = new HashSet<int>();
        while(n!=1 && !set.Contains(n)){
            set.Add(n);
            n = GetNext(n);
        }
        return n==1;
    }
    
    int GetNext(int n) {
        var sum = 0;
        while (n > 0) {
            var d = n % 10;
            n = n / 10;
            sum += d * d;
        }
        return sum;
    }
    
    [Theory]
    [InlineData(19, true)]
    [InlineData(2, false)]
    public void TestMethod(int n, bool expected)
    {
        var result = IsHappy(n);
        Assert.Equal(expected, result);
    }
}