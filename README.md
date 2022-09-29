# ArrayExtensions-KthLargest
This array extensions are written to find Kth largest element in an array, implmenting Hoare's qucik selection algorithm in C#.

###### Why
C# does not have built-in equivelant of C++ std::nth_element function.

###### Time Complexity O(N)
Using built-in functions, one has to use Array.Sort(arr) to find out kth largest element. This approach sort the whole array, which results in O(NlogN) time complexity.  
Using Hoare's qucik selection algorithm can identify the kth largest element by partially sorting the array, which brings the average time complextiy to O(N), worst case O(N^2).  
This extensions adds randomness in picking the pivot index to minimalise the chances of worst cases, therefore time complexity is almost certain O(N).

###### Application
Kth largest problems and variation.

https://leetcode.com/problems/find-subsequence-of-length-k-with-the-largest-sum/submissions/
