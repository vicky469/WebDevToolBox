Init: put the first interval into the merged list
1. Detect the overlap  
Compare (1st element in the interval, last element in the merged list)
if 1st element in the interval > last element in the merged list then no overlap, add to the list
2. If overlap, merge the intervals
Update the last element in the merged list