## Array/String
### Index was outside the bounds of the array.
- Corner cases:
  - null, empty, one element
- While loop:  
  - check how we want to return when we are at the last element of the array.  
    Do not let it increment and escape the loop to be an invalid index.
  - in order to keep in the boundary, it is generally preferred to write if else rather than if only and increment the index.


## Dictionary
### An item with the same key has already been added.
Always use TryAdd

https://leetcode.com
/problems/two-sum-ii-input-array-is-sorted/description/?envType=study-plan-v2&envId=top-interview-150