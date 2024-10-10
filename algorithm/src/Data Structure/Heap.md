Also known as
- binary heap
- nearly complete binary tree

## How is it used?
Job scheduling: keys correspond to priorities indicating which tasks are to be performed first
### priority queue  `<ADT>`
  A computer is capable of running several applications at the same time.   
  This effect is typically achieved by assigning a priority to events associated with applications, 
then always executing the event with the highest priority.

Compare to queues(remove the oldest) and stacks(remove the newest).

Data Structure operations:
1. key delMax() //remove the maximum
2. insert()

Items are kept in an array with certain ordering constraints for efficient implementations of the above operations.

## Types
### max-heap
<img src="https://i.gyazo.com/21497f045c59363fcbefc4cd59dd60ed.png"/>
    
### min-heap for priority queue
Why min-heap? Can't we just sort the array?  
In some data processing examples such as TopK and Multiway, the total amount of data is far too large to consider sorting. 

Problem:
We are looking for top 10 entries among a billion items.  
Solution: 
1. Create a min-heap with the first 10 items.
2. For each item, compare it with the root of the heap.
3. If the item is larger than the root, replace the root with the item and adjust the heap.
4. Repeat until all items are processed.

<img src="  https://i.gyazo.com/d1ace0cb8dd33aa8125edd7d3f1873c5.png"/>
<img src="https://i.gyazo.com/95f1cbdcd18b72d7f268ec8b3a11f429.png"/>
 floor(3/2) = 1  // round down the nearest whole number
<img src="https://i.gyazo.com/5b521a2ff909fb4d44e86842e8d5641c.jpg"/>
