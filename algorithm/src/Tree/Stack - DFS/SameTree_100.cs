using LeetCode.Data_Structure;

namespace LeetCode.Tree.Stack___DFS;

public class SameTree_100: TestBase
{
    
    bool IsSameTree(TreeNode p, TreeNode q)
    {
        var stack = new System.Collections.Generic.Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));
        while (stack.Count > 0)
        {
            (p, q) = stack.Pop();
            if (p == null && q == null) continue;

            if (p == null || q == null) return false;

            if (p.val != q.val) return false;

            stack.Push((p.right, q.right));
            stack.Push((p.left, q.left));
        }

        return true;
    }
    bool IsSameTree_Log(TreeNode p, TreeNode q)
    {
        var stack = new System.Collections.Generic.Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));
        TestOutputHelper.WriteLine($"PUSH p: {p?.val}, q: {q?.val}");
        while (stack.Count > 0)
        {
            (p, q) = stack.Pop();
            TestOutputHelper.WriteLine($"POP p: {p?.val}, q: {q?.val}");
            if (p == null && q == null)
                continue;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            stack.Push((p.right, q.right));
            stack.Push((p.left, q.left));
            TestOutputHelper.WriteLine($"PUSH p: {p?.right?.val}, q: {q?.right?.val}");
            TestOutputHelper.WriteLine($"PUSH p: {p?.left?.val}, q: {q?.left?.val}");
        }

        return true;
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test_OK(int testCaseId)
    {
        int?[] p = null;
        int?[] q = null;
        bool expectedResult = default;
    
        switch (testCaseId)
        {
            case 1:
                p = new int?[]{1,2};
                q = new int?[]{1,null,2};
                expectedResult = false;
                break;
            case 2:
            p = new int?[]{1,2,3};
            q = new int?[]{1,2,3};
            expectedResult = true;
            break;
            case 3:
                p = new int?[]{1,null,2,3};
                q = new int?[]{1,null,2,null,3};
                expectedResult = false;
                break;
        }
    
        var treeA = TreeNode.BuildTree(p);
        var treeB = TreeNode.BuildTree(q);
        var result = IsSameTree(treeA,treeB);
        Assert.Equal(expectedResult, result);
    }

    public SameTree_100(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}