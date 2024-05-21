55. Jump Game

<img height="400" src="https://i.gyazo.com/5ff56b7fe362245b1945d1b393e47ccc.png"/>


| i | Value | i+ value | maxReachableIndex |
|---|-------|----------|-------------------|
| 0 | 2     | 2        | 2                 |
| 1 | 3     | 4        | 4                 |
| 2 | 1     | 3        | 4                 |
| 3 | 1     | 4        | 4                 |
| 4 | 4     |          | End               |


<img height="300" src="https://i.gyazo.com/d86356a7484606f026fd062a8892e174.png"/>

| i                                    | Value | i+ value | maxReachableIndex                    |
|--------------------------------------|-------|----------|--------------------------------------|
| 0                                    | 3     | 3        | 3                                    |
| 1                                    | 2     | 3        | 3                                    |
| 2                                    | 1     | 3        | 3                                    |
| 3                                    | 0     | 3        | <span style="color:red">**3**</span> |
| <span style="color:red">**4**</span> |       |          |                                      |

// wrong solution
input [2, 0, 0]  
The code below will start at index 0, make a jump of 2 to index 2, then jump back to index 0, and so on, resulting in an infinite loop.
```c#
public bool CanJump(int[] nums) {
    var maxJumpIndex = 0;
    var i = 0;
    while(i < nums.Length){
        if(nums[i] == 0 && i == nums.Length-1) return false;
        maxJumpIndex = i + nums[i];
        i = maxJumpIndex;
    }
    return true;
}
```


45. Jump Game II

| i | Farthest | CurrentEnd | Jumps |
|---|----------|------------|-------|
| 0 | 2        | 2          | 1     |
| 1 | 4        | 2          | 1     |
| 2 | 4        | 4          | 2     |
| 3 | 4        | 4          | 2     |

Do we need to use dictionary to keep track the routes?
No. The goal of the problem is to find the minimum number of jumps to reach the end, not the actual path or sequence of jumps.