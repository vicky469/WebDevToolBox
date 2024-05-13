#2 two kinds of bracket orders

|   | Type                                                    | Example  |   |
|---|---------------------------------------------------------|----------|---|
| 1 | Immediate Close, nothing inside                         | `()[]{}` | ✅ |
| 2 | Close Later, another pair is inside and properly closed | `{[]}`   | ✅ |
|   | wrong order, imbalanced                                 | `([)]`   | ❌ |

### Two Pointer
```
Example 1:
0 1 2 3 4 5
{ ( [ ] ) }   => true

Example 2:
0 1 2 3 
( ) [ ]   => true

Example 3:
( )   => true

```

### Stack
1. If the length of s is odd, then IsValid(s) = false.
2. Let D be a dictionary mapping each opening bracket to its corresponding closing bracket.
3. Let P be an array of characters from s.
4. Let S be an empty stack.
5. For each character c in P:
   - If c is an opening bracket (i.e., c exists in D), push c onto S.
   - If c is a closing bracket:
     - If S is empty, then IsValid(s) = false.
     - Let o be the top element popped from S. If c does not correspond to o (i.e., they are not a pair according to D), then IsValid(s) = false.
6. If S is not empty after the iteration, then IsValid(s) = false. 
7. Return IsValid(s) = true.
