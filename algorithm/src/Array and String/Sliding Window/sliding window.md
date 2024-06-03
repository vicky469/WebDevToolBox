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

Applications:
1. Array and String Manipulation
Subarray, substring, or any other contiguous subsequence problems that satisfy certain conditions.
2. Data Compression
   Sliding window compression algorithms, like LZ77 and its variants, use a window to find repeated patterns in the input data and replace them with references to previous occurrences.
3. Image Processing
   Tasks such as feature extraction, object detection, or image segmentation.
4. Signal Processing
   Time-series data can be analyzed using a sliding window to capture local patterns, trends, or anomalies.
5. Network Protocols
   Sliding window protocols are used in computer networks for reliable and efficient data transmission. The sender and receiver maintain a window of allowable sequence numbers to manage the flow of data.



References:
https://www.freecodecamp.org/news/sliding-window-technique/