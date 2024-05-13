// https://leetcode.com/problems/binary-tree-inorder-traversal/description/

namespace LeetCode.Tree;
public class Inorder_BinaryTree_94
{
    //     1                                   1
    //  /    \                             /      \
    //  n     2                           2        3
    //       /                          /   \        \ 
    //     3                          4      5        7
    // res: [1,3,2]       左中右      res: [4,2,5,1,3,7]  
    public IList<int> InorderTraversal_DFS(TreeNode root) {
        var list = new List<int>();
        //TODO: 
        // var stack = new Stack<TreeNode>();
        // var curr = root;
        // while (curr.left != null)
        // {
        //     curr = root.left;
        // }
        // list.Add(curr);
        return list;
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
        var result = InorderTraversal_DFS(root);
        Assert.Equal(expectedResult, result);
    }
}