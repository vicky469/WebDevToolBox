### Understand the problem  
longest consecutive sequence 
- consecutive sequence: num-1, num, num+1...
- longest meaning we will have multiple sequences, we need to find the longest one


Input: [100, 4, 200, 1, 3, 2]  
Output: 4  

How do we identify the starting point of a sequence?  
It should not have a left neighbor.

1st starting point: 100
2nd starting point: 200
3rd starting point: 1

Once we have the starting point, we can keep checking the next number to see if it is in the set.

Inorder to fast get values, we can use a Set to store all the values.

### Steps
1. Create a set to store all the values
2. Iterate the array to find all the starting points
3. For each starting point, keep checking the next number to see if it is in the set  
   3.1  If it is in the set, count++  
   3.2  once the sequence ends, update the max count