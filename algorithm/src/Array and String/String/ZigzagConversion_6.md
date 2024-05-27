## Understand the problem
### Examples
Input: 
- string   ("PAYPALISHIRING")
- number of rows   (3)

Ask: 
Write the string in a zigzag pattern on the given number of rows, then read the result line by line.

Output: "PAHNAPLSIIGYIR"  
[PAHN]  
[APLSIIG]    
[YIR]  
<img height="140" src="https://i.gyazo.com/fa97b207713267ebc5587687b47f2791.jpg"/>

---
Input:
- string   ("PAYPALISHIRING")
- number of rows   (4)

Output: "PINALSIGYAHRPI"  
[PIN]  
[ALSIG]    
[YAHR]  
[PI]
<img height="160" src="https://i.gyazo.com/05195acadfb7e092ee1b3e3c09373183.jpg" />

### Finding patterns and constraints
Column 
- For each cycle, only the first column is attempting to be fully filled (except the last cycle).  
  Later columns can only have one element.
- `numCycles` = s.Length / numRows;
- `remainder` = s.Length % numRows;
- `numElementsInCycle` = (numRows - remainder) / numCycles;

<img height="400" src="https://i.gyazo.com/9d40a843c1cf1c9ed6af293b9d4e8fe3.png" width="200"/>

Row  
isDown = true;
- If `isDown` is true, the next row is row + 1.
- Else, the next row is row - 1.

**<span style="color:red;">For this problem, we only care about row.</span>**

pseudocode
```
initialize rows, each row is a stringbuilder
isDown = true
row = 0
for each character in the string
    add the character to the current row
    if the current row is the last row, set isDown to false
    if the current row is the first row, set isDown to true
    if isDown is true, increment the row
    else decrement the row
```


## Edge Cases 
-  If the number of rows is 1, the zigzag pattern is the same as the original string.

## Real World Use Cases
- `Data Encoding`  
    Used in the xx industry to encrypt the data before sending it to the server.
- `Cryptography`
    Make the data hard to decipher 解码.  
    Decipher: convert (a text written in code, or a coded signal) into normal language.
- `Data Storage`  
  optimize the way data is stored and retrieved. This can be particularly useful in systems where data is stored in a linear fashion but needs to be read in a non-linear way.
- `Signal Processing`  
  Zigzag conversion is used in signal processing to convert a signal from the time domain to the frequency domain. This is done by taking a signal and converting it into a series of zigzag patterns that can be analyzed to determine the frequency content of the signal.
