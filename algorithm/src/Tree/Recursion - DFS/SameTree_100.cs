using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

public class SameTree_100
{
    bool IsSameTree(TreeNode p, TreeNode q)
    {
        if(p==null && q == null) return true;
        if(p==null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
}