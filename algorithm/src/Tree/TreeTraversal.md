# Tree Traversal
## Preorder (root, left, right ｜ 中左右)
        1              
     /    \                      
     n     2                    
          /                  
        3
    res: [1,2,3]

Preorder traversal use cases:
- When creating a copy of the tree data structure
  1. create the parent nodes
  2. create current root's child nodes
- Used to get prefix expressions on an expression tree.
---

```c#
void PreOrder(TreeNode? node, List<int> list)
    {
        if (node == null) return;
        // Add root to the list
        list.Add(node.val);

        // 1) recur on left subtree
        PreOrderHelper(node.left, list);

        // 2) recur on right subtree
        PreOrderHelper(node.right, list);
}
```

## Inorder (left, root, right ｜ 左中右)
        1              
     /    \                      
     n     2                    
          /                  
        3                         
    res: [1,3,2]

1. visit all the nodes in the left subtree
2. root node
3. Visit all the nodes in the right subtree

#### Steps - Recursively:
```c#
void InOrder (TreeNode? root, List<int> list)
{
    if (root == null) return;
    InOrder(root.left, list);
    list.Add(root.val);
    InOrder(root.right, list);
}
```

#### Steps - Iteratively:
1. Create an empty stack.
2. Initialize current node as root.
3. Push the current node to the stack and set current = current.left until current is NULL.
4. If current is NULL and stack is not empty:
   - Pop the top item from the stack. 
   - Print the popped item, set current = popped_item.right. 
   - Go to step 3.
5. If current is NULL and stack is empty, then we are done.

| Stack   | Operation       |
|---------|-----------------|
| 1       | Push 1          |
| 1, 2    | Push 2          |
| 1, 2, 3 | Push 3          |
| 1, 2    | Pop 3, Output 3 |
| 1       | Pop 2, Output 2 |
|         | Pop 1, Output 1 |

## Postorder (left, right, root ｜ 左右中)
        1              
     /    \                      
     n     2                    
          /                  
        3                         
    res: [3,2,1]

```c#
void PostOrderHelper(TreeNode? node, List<int> list)
{
    if (node == null) return;
    PostOrderHelper(node.left, list);
    PostOrderHelper(node.right, list);
    list.Add(node.val);
}
```