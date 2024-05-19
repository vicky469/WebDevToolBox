### 1. Brute force
<img src="https://i.gyazo.com/9e0b3bfcbd1c2f8683bf6517bd8f7a2c.jpg" title="ss" width="300"/>


### 2. Reverse Three Times
<img src="https://i.gyazo.com/e1a47c24e77458a1632cc403bf3c73c5.jpg" title="ss" width="300"/>

### 3. Cyclic Replacements
1. Initialize a variable count to keep track of the number of elements we have moved to their correct position.  
2. Start from an index, and keep moving the elements to their correct position until we have moved n elements.
3. If we reach the starting index before we have moved n elements, increment the starting index (i) and continue the process.
<img src="https://i.gyazo.com/ee8a5e381fe0b79ea763baad80c052ae.jpg" title="ss" width="300"/>  

Input:
[1, 2, 3, 4, 5, 6 ], k = 2

[1, 2, 3, 4, 5, 6 ]  
[5, 2, 1, 4, 3, 6 ]  
[5, 6, 1, 2, 3, 4 ]
