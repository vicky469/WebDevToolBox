### What is given?

Symbol mapping:

| Symbol | Value |
|--------|-------|
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

How many cases?
1. large -> small  =>  add 
    ```
    Example 1:
    Input: s = "III"
    Output: 3
    Explanation: III = 3.
   
    Example 2:
    Input: s = "LVIII"
    Output: 58
    Explanation: L = 50, V= 5, III = 3.
   ```
2. small -> large  =>  subtract
   1. combine curr and prev
   2. res+= curr - prev - prev;
   subtract from the later larger number to the previous smaller number,
   and eliminate previous value from the result.
    ```
    Example 3:
    Input: s = "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
   ```
   
<img height="400" src="https://i.gyazo.com/c04f0830c563d748eef6ffba9275fed1.png" width="250"/>