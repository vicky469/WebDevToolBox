namespace LeetCode.Data_Structure;

public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode? next;
    
    public TreeNode() {
    }
    public TreeNode(int val=0) {
        this.val = val;
    }
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null, TreeNode? next=null) {
        this.next = next;
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public int Size
    {
        get
        {
            return SizeOfTree(this);
        }
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var node = (TreeNode)obj;
        return val == node.val && 
               ((left == null && node.left == null) || (left != null && left.Equals(node.left))) && 
               ((right == null && node.right == null) || (right != null && right.Equals(node.right)));
    }

    // When you override Equals, you should also override GetHashCode
    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + val.GetHashCode();
        hash = hash * 23 + (left != null ? left.GetHashCode() : 0);
        hash = hash * 23 + (right != null ? right.GetHashCode() : 0);
        return hash;
    }

    public static TreeNode? BuildTree(int?[] nums)
    {
        if (nums == null || nums.Length == 0) return null;

        var root = new TreeNode((int)nums[0]);
        var queue = new Queue<TreeNode?>();
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
    
    private int SizeOfTree(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }
        else
        {
            return (SizeOfTree(node.left) + 1 + SizeOfTree(node.right));
        }
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