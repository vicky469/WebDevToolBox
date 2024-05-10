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

        TreeNode[] nodes = new TreeNode[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].HasValue)
            {
                if (nodes[i] == null)
                {
                    nodes[i] = new TreeNode(nums[i].Value);
                }
                else
                {
                    nodes[i].val = nums[i].Value;
                }

                int left = 2 * i + 1;
                int right = 2 * i + 2;
                if (left < nums.Length && nums[left].HasValue)
                {
                    nodes[left] = new TreeNode(nums[left].Value);
                    nodes[i].left = nodes[left];
                }
                if (right < nums.Length && nums[right].HasValue)
                {
                    nodes[right] = new TreeNode(nums[right].Value);
                    nodes[i].right = nodes[right];
                }
            }
        }

        return nodes[0];
    }
    
}