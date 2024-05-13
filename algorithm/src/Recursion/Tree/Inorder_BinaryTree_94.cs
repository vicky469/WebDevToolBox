// https://leetcode.com/problems/binary-tree-inorder-traversal/description/

namespace LeetCode.Recursion.Tree;
public class Inorder_BinaryTree_94
{
    //    1                      
    //  /    \                          
    //  6     2       
    //       /                      
    //     3        
    // res: [6, 1, 3, 2]
    public IList<int> InorderTraversal(TreeNode root) {
        var list = new List<int>();
        InOrderHelper(root, list);
        return list;
    }
    private void InOrderHelper (TreeNode root, List<int> list){
        if (root != null)
        {
            // traverse left
            InOrderHelper(root.left, list);
            // add root
            list.Add(root.val);
            // traverse right
            InOrderHelper(root.right, list);
        }
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