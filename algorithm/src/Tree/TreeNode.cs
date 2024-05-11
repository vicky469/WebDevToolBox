namespace LeetCode.Tree;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode BuildTree(int?[] nums)
    {
        if (nums == null || nums.Length == 0) return null;

        var root = new TreeNode((int)nums[0]);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isLeft = true;
        
        for (var i = 1; i < nums.Length; i++)
        {
            var currentRoot = queue.Peek();
            var node = nums[i].HasValue ? new TreeNode((int)nums[i]) : null;
            if (currentRoot != null)
            {
                // this is for the left node
                if (isLeft)
                {
                    currentRoot.left = node;
                }
                else
                {
                    currentRoot.right = node;
                    queue.Dequeue();
                }
                if (node != null)
                {
                    queue.Enqueue(node);
                }
                isLeft = !isLeft;
            }
        }
        
        return root;
    }
    
    [Theory]
    [MemberData(nameof(TreeNodeTests.TestCases), MemberType = typeof(TreeNodeTests))]
    public void Test_OK(TreeNodeTests testCase)
    {
        var root = BuildTree(testCase.Vals);
        Assert.Equal(testCase.ExpectedResult[0], root.val);
        Assert.Equal(testCase.ExpectedResult[1], root.left.val);
        Assert.Equal(testCase.ExpectedResult[2], root.right.val);
        Assert.Equal(testCase.ExpectedResult[3], root.left.left.val);
        Assert.Equal(testCase.ExpectedResult[4], root.left.right.val);
        Assert.Null(root.right.left);
        Assert.Equal(testCase.ExpectedResult[5], root.right.right.val);
    }
}