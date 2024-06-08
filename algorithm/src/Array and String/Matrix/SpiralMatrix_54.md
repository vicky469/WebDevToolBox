
![](https://i.gyazo.com/4cfa4c37519b46e711d9fc9423776bf8.png)
Create 4 variables to represent the boundaries of the matrix: 
- top
- bottom
- left
- right
  
❗ keep the above pointers in their boundaries.

on the top row, from left to right  ➡️  
top++;  
on the right column, from top to bottom  ⬇️  
right--;  

check top and bottom boundary again  
on the bottom row, from right to left  ⬅️  
bottom--;  

check left and right boundary again  
on the left column, from bottom to top  ⬆️  
left++  


Corner Cases: 
1 element
![](https://i.gyazo.com/2879b2b53d0f86232afaf07eb706cbb4.png)
2 elements
![](https://i.gyazo.com/528f877aae99eadf0864e68dbb154572.png)
4 elements
![](https://i.gyazo.com/d3438813eb52cae18a2b86ede25cc353.png)

