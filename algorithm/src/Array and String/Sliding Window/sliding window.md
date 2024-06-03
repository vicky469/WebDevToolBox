`Sliding window` is useful when we have a set of data (like an array or string), we are looking for a subset of that data that is **continuous** in some way.

Difference between Sliding Window and Two Pointers:

| Sliding Window                                   | Two Pointers                                                                                                            |
|--------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| Typically use all the elements within the window | At one point of time, we usually compare the value at the two pointers instead of all the elements between the pointers |
| e.g., sum of all elements in the window          |                                                                                                                         |

Steps:    
1. Define the window size n.  
2. Start from the first element and add up to n elements in the array to form the first window.  
3. Slide the window by one position to the right for the next iteration (i.e., remove the first element of the window and add the next element in the array to the window).  
4. Repeat step 3 until the window has slid to the end of the array.