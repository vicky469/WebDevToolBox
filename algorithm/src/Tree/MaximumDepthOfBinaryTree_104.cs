namespace LeetCode.Tree;
// https://leetcode.com/problems/maximum-depth-of-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150
public class MaximumDepthOfBinaryTree_104
{
    public int MaxDepth_BFS(TreeNode? root) {
        var maxDepth = 0;
        if (root == null) return maxDepth;
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            // level by level
            for (var i = 0; i < size; i++)
            {
                // remove the node from the first item in the queue
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            maxDepth++;
        }
        return maxDepth;
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        int expectedResult = default;
    
        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{3,9,20,null,null,15,7};
                expectedResult = 3;
                break;
            // Add more cases as needed
        }
    
        var root = TreeNode.BuildTree(nums);
        var result = MaxDepth_BFS(root);
        Assert.Equal(expectedResult, result);
    }
    
}