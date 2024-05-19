### Use Cases
You’ll encounter tree data structures only if you are dealing with low-level details.
- abstract syntax trees
- priority queues
- Adelson-Velsky-Landis (AVL) trees, etc.

### Keep In Mind
- Tree data structure can be cery deep which will cause a stack overflow.
  - This happens because each level deeper into the tree requires yet another function call, and too many function calls without returning cause stack overflows.
  - However, it’s unlikely for broad, well-balanced trees to be that deep. 
  - If every node in a 1,000 level deep tree has two children, the tree would have about 2^1000 nodes.

# What is a Binary Tree
Each node in a Binary Tree has three parts:
1. Value
2. Left child
3. Right child

# Kinds of Binary Trees
### FullBinaryTree
| Queue   | Operation             |
|---------|-----------------------|
| 1       | ADD root to the queue |
|         | POP root              |
| 2       | ADD left              |
| 2, 3    | ADD right             |
| 3       | POP node 2            |
| 3, 4    | ADD left 4            |
| 3, 4, 5 | ADD right 5           |
| 4, 5    | POP node  3           |
| 5       | POP node  4           |
|         | POP node  5           |
