// https://leetcode.com/problems/symmetric-tree/description/?envType=study-plan-v2&envId=top-interview-150

using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

public class SymmetricTree_101
{
    bool IsSymmetric(TreeNode root) {
        if(root.left == null && root.right == null) return true;
        if(root.left == null || root.right == null) return false;
        return IsMirror(root.left, root.right);
    }
    
    bool IsMirror(TreeNode p, TreeNode q){
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(p.val != q.val) return false;
        return IsMirror(p.left, q.right) && IsMirror(p.right, q.left);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        bool expectedResult = false;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[] { 1, 2, 2, null, 3, null, 3 };
                expectedResult = false;
                break;
            case 2:
                nums = new int?[] { 1, 2, 2, 3, 4, 4, 3 };
                expectedResult = true;
                break;
            case 3:
                nums = new int?[] { 1,2,2,null,3,null,3};
                expectedResult = false;
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var result = IsSymmetric(root);
        Assert.Equal(expectedResult, result);
    }
}