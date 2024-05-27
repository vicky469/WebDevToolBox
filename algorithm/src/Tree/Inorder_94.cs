// https://leetcode.com/problems/binary-tree-inorder-traversal/description/

using LeetCode.Data_Structure;

namespace LeetCode.Tree;
public class Inorder_94
{
    //    1                      
    //  /    \                          
    //  6     2       
    //       /                      
    //     3        
    // res: [6, 1, 3, 2]
    public IList<int> InorderTraversal(TreeNode? root) {
        var list = new List<int>();
        InOrder(root, list);
        return list;
    }
    void InOrder (TreeNode? root, List<int> list)
    {
        if (root == null) return;
        InOrder(root.left, list);
        list.Add(root.val);
        InOrder(root.right, list);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        List<int>  expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,null,2,3};
                expectedResult = new List<int>{1,3,2};
                break;
            case 2:
            nums = new int?[]{1,6,2,3, null};
            expectedResult = new List<int> {6, 1, 3, 2};
            break;
        }

        var root = TreeNode.BuildTree(nums);
        var result = InorderTraversal(root);
        Assert.Equal(expectedResult, result);
    }
}