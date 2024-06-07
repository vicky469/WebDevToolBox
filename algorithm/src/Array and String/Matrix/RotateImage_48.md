keywords: Symmetries of a Square
Problem: R90
### Transpose and Reflect
The most elegant solution for rotating the matrix is to first reverse the matrix around the main diagonal, and then reverse it from left to right. These operations are called transpose and reflect in linear algebra.
1. Transpose the matrix 
![](https://i.gyazo.com/276bba3accf4d28f453ac2fd3b4e8802.png)
2. Reflect  (reverse each row)


Ref:
https://leetcode.com/problems/rotate-image/editorial/?envType=study-plan-v2&envId=top-interview-150  
https://www.khanacademy.org/math/linear-algebra/matrix-transformations/matrix-transpose/v/linear-algebra-transpose-of-a-matrix


======== garbage, not used  ===========   
![](https://i.gyazo.com/e274522a5f08eed2ad2d32a675db06fb.png)  
We can see this as layers of squares. And we rotate layer by layer.

For each layer, we rotate 4 corner elements in the square. The columns we need to traverse is from left most column to right most column in the current layer.
![](https://i.gyazo.com/7b8d002b0709015a316215913259192f.png)


![](https://i.gyazo.com/7d7101427376aea6a84c107db35ebc19.png)
![](https://i.gyazo.com/75b61ae50c42a89046d8169edb68057d.png)
