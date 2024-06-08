### Rules

| Original | Rule         | New |
|----------|--------------|-----|
| 1        | 1s < 2       | 0   |
| 1        | 1s in [2 ,3] | 1   |
| 1        | 1s > 3       | 0   |
| 0        | 1s == 3      | 1   |


### Truth Table & State Transition

| Original | New | State |
|----------|-----|-------|
| 0        | 0   | 0     |
| 1        | 0   | 1     |
| 0        | 1   | 2     |
| 1        | 1   | 3     |

### Merge In One View

| Original | Rule               | New | State |
|----------|--------------------|-----|-------|
| 1        | 1s < 2  or  1s > 3 | 0   | 1     |
| 1        | 1s in [2 ,3]       | 1   | 3     |
| 0        | 1s == 3            | 1   | 2     |

### Follow-up:  
In this question, we represent the board using a 2D array. In principle, the board is infinite, which would cause problems when the active area encroaches upon the border of the array (i.e., live cells reach the border). How would you address these problems?