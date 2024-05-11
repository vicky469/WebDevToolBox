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