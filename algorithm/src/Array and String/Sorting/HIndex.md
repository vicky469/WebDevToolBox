The H-Index is a measure of the productivity and impact of a researcher's publications.   

Definition
A scholar with an index of h:
- has published h papers 
- have each been cited at least h times.

Steps to calculate the H-Index:
1. Sort the citation counts in descending order.
2. Traverse the sorted list. The H-Index is the last position where the citation count >= position.
3. If such a position doesn't exist, the H-Index is 0.

Explore different cases:

| Case | Citations Array  | Sorted Citations Array | H-Index | Explanation                                                                                                                |
|------|------------------|------------------------|---------|----------------------------------------------------------------------------------------------------------------------------|
| 1    | [1, 4, 1, 4, 2]  | [4, 4, 2, 1, 1]        | 2       | The sorted array shows that the 2nd highest citation count is 2, and there are at least 2 papers with 2 or more citations. |
| 2    | [100]            | [100]                  | 1       | There is only one paper, and it has been cited 100 times. So, the H-Index is 1.                                            |
| 3    | [0, 0, 0]        | [0, 0, 0]              | 0       | None of the papers have been cited, so the H-Index is 0.                                                                   ||
| 5    | [10, 8, 5, 4, 3] | [10, 8, 5, 4, 3]       | 4       | The 4th highest citation count is 4, and there are at least 4 papers with 4 or more citations.                             |