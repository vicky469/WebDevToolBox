namespace LeetCode.Tree;

public class MaximumDepthOfBinaryTree_104
{
    public int MaxDepth(TreeNode root) {
        var maxDepth = 0;
        if (root == null) return maxDepth;
        // BFS, use queue to keep track of nodes to be processed.
        var queue = new Queue<TreeNode>();
        // Add root to queue
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            // level by level
            for (var i = 0; i < size; i++)
            {
                // remove the node from the first item in the queue
                var node = queue.Dequeue();
                // add left and right node to the queue
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
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
        int expectedResult = 0;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{3,9,20,null,null,15,7};
                expectedResult = 3;
                break;
            // Add more cases as needed
        }

        var root = TreeNode.BuildTree(nums);
        var result = MaxDepth(root);
        Assert.Equal(expectedResult, result);
    }
    
}