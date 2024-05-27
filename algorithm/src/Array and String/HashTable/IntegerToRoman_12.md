#### Constraints:
  1 <= num <= 3999  
  `why the upper bound is 3999?`

  Because rule #3, M can be appended at most 3 times.  
  Detail:  
  The upper bound is 3999 because of the limitations of the Roman numeral system. In the Roman numeral system, the largest symbol is M, which represents 1000. According to the rules of the Roman numeral system, a symbol can be repeated at most three times. Therefore, the largest number that can be represented using the Roman numeral system is MMM, or 3000.  However, we can represent numbers larger than 3000 by using the subtractive principle, where a smaller number is placed before a larger number to indicate subtraction. The largest number we can represent using this principle is 900 (CM), which is 1000 (M) minus 100 (C).  When we add this to 3000 (MMM), we get 3900. We can then add 90 (XC), which is 100 (C) minus 10 (X), to get 3990. Finally, we can add 9 (IX), which is 10 (X) minus 1 (I), to get 3999.  Therefore, the largest number that can be represented using the Roman numeral system, following the standard rules, is 3999.
  

## Rules
### 1. General case: IF NOT start with `4` or `9`:
symbol = input -  max(map.key)

### 2. Special case: IF start with `4` or `9`:
 4, 9, 40, 90, 400, 900  
use the subtractive form:
4 (IV), 9 (IX), 40 (XL), 90 (XC), 400 (CD) and 900 (CM).
- 4 is 1 (I) less than 5 (V)
- IV and 9 is 1 (I) less than 10 (X): IX. 

### 3. Consecutive rules:
Only powers of 10 (I, X, C, M) can be appended consecutively at most 3 times.
You cannot append 5 (V), 50 (L), or 500 (D) multiple times.


<img height="300" src="https://i.gyazo.com/bbb69b598fff96aadf4bc7196cc1fa70.png" width="500"/>