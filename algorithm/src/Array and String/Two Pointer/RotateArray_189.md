### 1. Brute force

<img src="https://i.gyazo.com/9e0b3bfcbd1c2f8683bf6517bd8f7a2c.jpg" title="ss" width="300"/>

### 2. Reverse Three Times

<img src="https://i.gyazo.com/e1a47c24e77458a1632cc403bf3c73c5.jpg" title="ss" width="300"/>

### 3. Cyclic Replacements & Modular

Key idea is to use modular to find the correct position for each element.

1. Initialize a variable count to keep track of the number of elements we have moved to their correct position.  
   The total number of elements in the array is n. We must move n elements.
2. In the do while loop, we keep moving elements to their correct position until we finish one cycle.

Input:  [1, 2, 3 ], k = 1  
Output: [3, 1, 2]   
<img src="https://i.gyazo.com/328f571db0de3d39beb2fd9bbbe1bd2d.png" title="ss" width="300"/>   
<img src="https://i.gyazo.com/09f092a626ee5016bcb74e290a8d9339.jpg" title="ss" width="300"/>   
<img src="https://i.gyazo.com/573d8295c606213e50897eb37ae7aa29.png" title="ss" width="800"/>  
