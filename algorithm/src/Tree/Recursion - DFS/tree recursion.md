### IsSymmetric
p.val = q.val  
p.left = q.right && p.right = q.left

<img width = "200" src="https://assets.leetcode.com/uploads/2021/02/19/symtree1.jpg"/>


### Same Tree
p.val = q.val  
p.left = q.left && p.right = q.right

<img width = "300" src="https://assets.leetcode.com/uploads/2020/12/20/ex1.jpg"/>


### InvertTree
<img width = "300" src="https://assets.leetcode.com/uploads/2021/03/14/invert1-tree.jpg"/>

```
var tmp  = root.left;
root.left = InvertTree(root.right);
root.right = InvertTree(tmp);
```