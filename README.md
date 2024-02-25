# Algorithms and Data Structures
## Sorting
### Insertion Sort
Insertion sort works by repeatedly taking the next element from the unsorted part of an array and inserting it in the correct position in the sorted part of the array.

This is an efficient algorithm for sorting a small or partially sorted array.

The following pseudo-code illustrates how the algorithm works:

```
for i from 1 to length(array) - 1 do
    key = array[i]
    j = i - 1
    while j >= 0 and array[j] > key do
        array[j + 1] = array[j]
        j = j - 1
    end while
    array[j + 1] = key
end for
```

***Worst case running time:*** $`O(n^2)`$

***Average case running time:*** $`O(n^2)`$

***Best case running time:*** $`O(n)`$
