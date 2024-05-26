### Definition
The H-Index is a measure of the productivity and impact of a researcher's publications.   
A scholar with an index of h:
- has published h papers 
- have each been cited at least h times.

### Steps to calculate the H-Index:
1. Sort the citation counts in `descending` order.
2. Traverse the sorted list.has cited at least `i` times, then the H-Index is `i`.  
   For each element(citation count), if the element >= i+1, then increment hIndex.


### Detail

To manually calculate your h-index, organize articles in descending order, based on the number of times they have been cited.
<img src="https://libapps-ca.s3.amazonaws.com/accounts/149714/images/H-index.jpg"/>

In the below example, an author has 8 papers that have been cited [33, 30, 20, 15, 7, 6, 5, 4] times. This tells us that the author's **h-index is 6**.

#### What does an h-index of 6 mean?
An h-index of 6 means that this author has published at least 6 papers that have each received at least 6 citations.

#### More context:
- The first paper has been cited 33 times, and gives us a 1 (there is one paper that has been cited at least once). 
- The second paper has been cited 30 times, and gives us a 2 (there are two papers that have been cited at least twice). 
- The third paper gives us a 3 and all the way up to 6 with the sixth highest paper. 
- The final two papers have no effect in this case as they have been cited less than 7 and 8 times.




Reference:  
https://subjectguides.uwaterloo.ca/calculate-academic-footprint/YourHIndex