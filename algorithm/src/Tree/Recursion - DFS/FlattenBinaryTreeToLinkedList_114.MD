
<img height="150" src="https://i.gyazo.com/f471a7ec5c7e30540a1324fbd661cc59.png" width="400"/>
Need to be in-order: &nbsp; &nbsp; root -> left -> right

Assuming we have already flattened the left subtree and right subtree, how can we connect and move the left subtree to the right subtree?

| Input Root | Base Case | Recursive Case           | Recursive Action              |
|------------|-----------|--------------------------|-------------------------------|
| 1          |           | Start to flatten 1.left  |                               |
| 2          |           | Start to flatten 2.left  |                               |
| 3          |           | Start to flatten 3.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 3.right |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 2.right |                               |
| 4          |           | Start to flatten 4.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 4.right |                               |
|            | Return    |                          |                               |
|            |           |                          | store `root.right` as temp: 4 |            
|            |           |                          | root.right = root.left: 3     |
|            |           |                          | root.right = temp: 4          |
|            |           | start to flatten 1.right |                               |
| 5          |           | Start to flatten 5.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 5.right |                               |
| 6          |           | Start to flatten 6.left  |                               |
|            | Return    |                          |                               |
|            |           | Start to flatten 6.right |                               |
|            | Return    |                          |                               |
|            |           |                          | store `root.right` as temp: 5 |
|            |           |                          | root.right = root.left: 2     |
|            |           |                          | root.right = temp: 5          |

1. Flatten the left subtree  
   <img height="250" src="https://i.gyazo.com/083cb9ce3b899cab4576379bd4fa5185.png" width="600"/>

2. Flatten the right subtree  
   <img height="250" src="https://i.gyazo.com/836095ea0647306dd6db75eb0a9a776c.png" width="700"/>
3. Finally, connect the left subtree to the right subtree  
<img height="250" src="https://i.gyazo.com/d5084bf67eb01848afb0b13f70254745.png" width="600"/>


