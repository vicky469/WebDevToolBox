Use a dummy node as a placeholder to maintain a reference to the head of the list while traverse and modify it, allowing you to freely modify the list without losing the reference to the head.  
<img width ="400" height="150" src="https://assets.leetcode.com/uploads/2019/02/15/117_sample.png"/>


Log

startNode = 1  
prev.next = curr.left    0 -> 2  
prev = 2  
prev.next = curr.right    2 -> 3  
prev = 3  
startNode = dummy.next  2  

================

startNode = 2  
prev.next = curr.left    0 -> 4  
prev = 4  
prev.next = curr.right    4 -> 5  
prev = 5  

================

startNode = 3  
prev.next = curr.right    5 -> 7  
prev = 7  
startNode = dummy.next  4  

================

startNode = 4  
startNode = 5  
startNode = 7  
startNode = dummy.next  
