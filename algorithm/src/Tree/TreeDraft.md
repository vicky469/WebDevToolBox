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



--------------
### Inorder (左中右)
        1              
     /    \                      
     n     2                    
          /                  
        3                         
    res: [1,3,2]

#### Steps - Recursively:
1. Create a variable to store the values of nodes visited. 
2. Create a variable `curr` to store the root
3. Write a helper function that takes the root, and values as arguments.
   - Base case: If the root is empty, return. 
   - Traverse the left subtree. 
   - Add the root to the list that stores the return values. 
   - Traverse the right subtree.

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