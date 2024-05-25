### ReverseString
High level idea:  
Head and tail pointer approach.  
- swap the head and tail

Base case:
- if the string is null or empty return
- if the string has only one character return

Recursive case:
- get the head, str.Substring [0]          // get needed data
- get the tail, str.Substring [1...n-1]   // get needed data
- recursively swap the head and tail     // real work (data + data)

Time complexity: O(n)  
Space complexity: O(n)  

Original, break it down to smaller problem, until we reach the base case
<img src="https://i.gyazo.com/21bdd6b619a8c9ff83171f3ba41c68f8.jpg" height="350" width="400"/>

Starting to reverse all the way up
<img src="https://i.gyazo.com/96bd398524b4de42fa836642b2b45f4f.jpg" height="350" width="400"/>
<img src="https://i.gyazo.com/0fc39c894a69a844fbcf1bcd9b9fe32b.jpg" height="350" width="400"/>

Final Result of the Reversed String
<img src="https://i.gyazo.com/814ceeea128570a0599c520ea703e423.jpg" height="350" width="400"/>


Note: The word is missing r, should be "cartier". But the idea is there.  
