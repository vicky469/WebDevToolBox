252. Meeting Rooms  
sort by start time
<img src="https://i.gyazo.com/0ac68d4e4f03ebe53b5ba66fbb46ad1c.png"/>

253. Meeting Rooms II
<img src="https://i.gyazo.com/50d654e2998d304fa6f23b5c42af6890.png"/>  
### Two approaches:
#### 1. min-heap
- Sort the intervals by start time. 
- Initialize a priority queue (min-heap) to keep track of the end times of the meetings. The meeting that ends the earliest will be at the top of the heap. 
  - For each meeting:  
    if it starts after the earliest ending meeting, they share a room.  
    Remove the earliest ending meeting from the room allocation and add the current one.
- The size of the heap at any point is the number of rooms needed to hold all the meetings up to that point.

#### 2. Sweep Line
   1. The algorithm first separates the start and end times of all meetings into two separate arrays.
   2. Both arrays are then sorted. The start times array is sorted in ascending order, and the end times array is also sorted in ascending order.
   3. Two pointers are initialized at the beginning of the start and end times arrays.
   4. The algorithm then "sweeps" from the earliest time to the latest time. At each time, it checks if it's a start time or an end time:
   - If it's a start time:
   a new meeting is starting, so a new room is needed. The algorithm increments the count of used rooms and moves the start pointer to the next start time.
   
   - If it's an end time:
   a meeting is ending, so a room is freed up. The algorithm decrements the count of used rooms and moves the end pointer to the next end time.
   The maximum number of rooms used at any point during the sweep is the minimum number of rooms needed to schedule all meetings.