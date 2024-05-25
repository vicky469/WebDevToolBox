namespace LeetCode.Tree;
//TODO: come back later
public class PopulatingNextRightPointersInEachNodeII_117: TestBase
{
    // level order traversal
    // instead of using queue, we can use dummy node to connect the next node
    TreeNode Connect(TreeNode root)
    {
        var startNode = root;
        while (startNode != null) {
            var dummy = new TreeNode(); // a placeholder to keep track of the fist node of the next level
            var prev = dummy; // used to traverse and connect the nodes at the current level, it will be at the end of each level. 
            for (var curr = startNode; curr != null; curr = curr.next) {
                // trying to connect all the nodes at the current level from left to right
                if (curr.left != null) {
                    prev.next = curr.left;
                    prev = prev.next;
                }
                if (curr.right != null) {
                    prev.next = curr.right;
                    prev = prev.next;
                }
            }
            startNode = dummy.next; // move to the next level
        }
        return root;
    }
    
    TreeNode ConnectPrint(TreeNode root)
    {
        var startNode = root;
        while(startNode != null){
            var dummy = new TreeNode(); // a placeholder to keep track of the fist node of the next level
            var prev = dummy; // used to traverse and connect the nodes at the current level, it will be at the end of each level. 
            for (var curr = startNode; curr != null; curr = curr.next) {
                TestOutputHelper.WriteLine($"startNode = {curr.val}");
                if (curr.left != null) {
                    prev.next = curr.left;
                    TestOutputHelper.WriteLine($"prev.next = curr.left    {prev?.val} -> {curr.left?.val}");
                    prev = prev.next;
                    TestOutputHelper.WriteLine($"prev = {prev?.val}");
                }
                if (curr.right != null) {
                    prev.next = curr.right;
                    TestOutputHelper.WriteLine($"prev.next = curr.right    {prev?.val} -> {curr.right?.val}");
                    prev = prev.next;
                    TestOutputHelper.WriteLine($"prev = {prev?.val}");
                }
            }
            startNode = dummy.next; // move to the next level
            TestOutputHelper.WriteLine($"startNode = dummy.next  {dummy.next?.val}");
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