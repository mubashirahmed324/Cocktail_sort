# Cocktail_sort
A sorting method
Cocktail Shaker Sort also known as bidirectional bubble sort, cocktail sort, shaker sort, shuttle sort, shuffle sort and ripple sort is a variation of Bubble sort. The Bubble sort algorithm always traverses elements from left and moves the largest element to its correct position in first iteration and second largest in second iteration and so on. Cocktail Sort traverses through a given array in both directions alternatively.

ALGORITHM:

Each iteration of the algorithm is broken up into 2 stages:
1.	The first stage loops through the array from left to right, just like the Bubble Sort. During the loop, adjacent items are compared and if value on the left is greater than the value on the right, then values are swapped. At the end of first iteration, largest number will reside at the end of the array.
2.	The second stage loops through the array in opposite direction- starting from the item just before the most recently sorted item, and moving back to the start of the array. Here also, adjacent items are compared and are swapped if required.

WORKING:
Let us consider an example array (5 1 4 2 8 0 2)

First Forward Pass:

(5 1 4 2 8 0 2)? (1 5 4 2 8 0 2), Swap since 5 > 1
(1 5 4 2 8 0 2)? (1 4 5 2 8 0 2), Swap since 5 > 4
(1 4 5 2 8 0 2)? (1 4 2 5 8 0 2), Swap since 5 > 2
(1 4 2 5 8 0 2)? (1 4 2 5 8 0 2)
(1 4 2 5 8 0 2)? (1 4 2 5 0 8 2), Swap since 8 > 0
(1 4 2 5 0 8 2)? (1 4 2 5 0 2 8), Swap since 8 > 2

After first forward pass, greatest element of the array will be present at the last index of array.
First Backward Pass:

(1 4 2 5 0 2 8)? (1 4 2 5 0 2 8)
(1 4 2 5 0 2 8)? (1 4 2 0 5 2 8), Swap since 5 > 0
(1 4 2 0 5 2 8)? (1 4 0 2 5 2 8), Swap since 2 > 0
(1 4 0 2 5 2 8)? (1 0 4 2 5 2 8), Swap since 4 > 0
(1 0 4 2 5 2 8)? (0 1 4 2 5 2 8), Swap since 1 > 0

After first backward pass, smallest element of the array will be present at the first index of the array.
Second Forward Pass:

(0 1 4 2 5 2 8)? (0 1 4 2 5 2 8)
(0 1 4 2 5 2 8)? (0 1 2 4 5 2 8), Swap since 4 > 2
(0 1 2 4 5 2 8)? (0 1 2 4 5 2 8)
(0 1 2 4 5 2 8)? (0 1 2 4 2 5 8), Swap since 5 > 2

Second Backward Pass:

(0 1 2 4 2 5 8)? (0 1 2 2 4 5 8), Swap since 4 > 2
Now, the array is already sorted, but our algorithm doesn’t know if it is completed. The algorithm needs to complete this whole pass without any swap to know it is sorted.
(0 1 2 2 4 5 8)? (0 1 2 2 4 5 8)
(0 1 2 2 4 5 8)? (0 1 2 2 4 5 8

TIME COMPLEXITY:

The complexity of the cocktail shaker sort in big O notation is O(n^2) for both the worst case and the average case, but it becomes closer to O(n)  if the list is mostly ordered before applying the sorting algorithm. For example, if every element is at a position that differs by at most k (k ≥ 1) from the position it is going to end up in, the complexity of cocktail shaker sort becomes O(kn)

Worst complexity: O(n^2)
Average complexity: O(n^2)
Best complexity: O(n)
Worst case Space complexity: O (1)

IMPLEMENTATION:

1.	At first you have to enter the size of array ( the number of elements you want to sort)
2.	Now enter the values in the array that you want to sort
3.	After complete insertion of values the console 1st show the unsorted array according to the sequence in which you enter the values and then it gives a sorted output in which it prints the complete sorted array.
