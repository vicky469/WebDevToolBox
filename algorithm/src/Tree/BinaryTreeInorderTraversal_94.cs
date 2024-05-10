using LeetCode.Data_Structure;

namespace LeetCode.Tree;
// https://leetcode.com/problems/binary-tree-inorder-traversal/description/
public class BinaryTreeInorderTraversal_94
{
    public IList<int> inorderTraversal(TreeNode root) {
        var list = new List<int>();
        InOrderHelper(root, list);
        return list;
    }
    private void InOrderHelper (TreeNode root, List<int> list){
        if (root != null)
        {
            InOrderHelper(root.left, list);
            list.Add(root.val);
            InOrderHelper(root.right, list);
        }
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        int[] expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,null,2,3};
                expectedResult = new int[]{1,3,2};
                break;
            // Add more cases as needed
        }

        var root = TreeNode.BuildTree(nums);
        var result = inorderTraversal(root);
        Assert.Equal(expectedResult, result);
    }
}