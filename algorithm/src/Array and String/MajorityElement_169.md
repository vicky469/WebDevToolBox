### Boyer-Moore Voting Algorithm
Assumption: guarantee that the majority element always exists in the array
```
                         i
Input [3, 2, 1, 1, 1, 2, 1] 
```

| i | cnt | candidate | nums[i] |
|---|-----|-----------|---------|
| 0 | 0   | 3         | 3       |
|   | 1   |           |         |
| 1 | 0   |           | 2       |
| 2 | 1   | 1         | 1       |
| 3 | 2   |           | 1       |
| 4 | 3   |           | 1       |
| 5 | 2   |           | 2       |
| 6 | 3   |           | 1       |
