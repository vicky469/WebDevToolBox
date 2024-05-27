using LeetCode.Data_Structure;

namespace LeetCode.Tree.Queue___BFS;

public class PopulatingNextRightPointersInEachNodeII_117: TestBase
{
    TreeNode Connect(TreeNode root)
    {
        if(root == null) return root;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var count = q.Count;
            TreeNode prev = null;
            for(var i = 0; i < count;i++){
                var cur = q.Dequeue();
                if(cur.right != null)  q.Enqueue(cur.right);
                if(cur.left != null)  q.Enqueue(cur.left);
                
                cur.next = prev;
                prev = cur;
            }
        }
        return root;
    }
    
    TreeNode ConnectPrint(TreeNode root)
    {
        if(root == null) return root;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var count = q.Count;
            TestOutputHelper.WriteLine($"queue size: {count}");
            TreeNode prev = null;
            for(var i = 0; i < count;i++){
                var cur = q.Dequeue();
                if(cur.right != null)  q.Enqueue(cur.right);
                if(cur.left != null)  q.Enqueue(cur.left);
                // Print queue values
                TestOutputHelper.WriteLine($"i = {i}, queue values: {string.Join(",", q.Select(node => node.val))}");
                cur.next = prev;
                TestOutputHelper.WriteLine($"{cur.val} -> {prev?.val}");
                prev = cur;
                TestOutputHelper.WriteLine($"prev = curr {prev?.val}");
            }
        }
        return root;
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
    
        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,3,4,5,null,7};
                
                break;
            // Add more cases as needed
        }
    
        var root = TreeNode.BuildTree(nums);
        var result = ConnectPrint(root);
        
        //Assert.Equal(expectedResult, actualResult);
    }

    public PopulatingNextRightPointersInEachNodeII_117(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}