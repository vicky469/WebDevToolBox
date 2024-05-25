```
        3
    /       \
   9         20
            /   \
           15    7
```
// 中左右
preorder = {<span style="color:green">3</span>,9,<span style="color:green">20</span>,15,7};

// 左中右
inorder = {9,<span style="color:green">3</span>,15,<span style="color:green">20</span>,7};  


Result: [3, 9, 20, null, null, 15, 7]

STEPS:
1. Use Preorder to find the root node value.
   rootVal = preorder[0];
2. Use Inorder to find the root node index, then recursively split the array into two subtrees.
   - Find the root node index in inorder array. 
   - Find the left subtree from preorder and inorder array. 
   - Find the right subtree from preorder and inorder array.
3. Recursively build the left subtree and right subtree.
4. Return the root node.

Log:  
INPUT: preorder: 3,9,20,15,7; inorder: 9,3,15,20,7  
rootVal: 3  
mid: 1  

INPUT: preorder: 9; inorder: 9  
rootVal: 9  
mid: 0  
Finished root.left:   
Finished root.right:   
Finished root.left: 1  

INPUT: preorder: 20,15,7; inorder: 15,20,7  
rootVal: 20  
mid: 1  

INPUT: preorder: 15; inorder: 15  
rootVal: 15  
mid: 0  
Finished root.left:   
Finished root.right:   
Finished root.left: 1  

INPUT: preorder: 7; inorder: 7  
rootVal: 7  
mid: 0  
Finished root.left:   
Finished root.right:   
Finished root.right: 1  
Finished root.right: 3  