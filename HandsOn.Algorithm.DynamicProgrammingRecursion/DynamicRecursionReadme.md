# Dynamic programming / Recursion

## Compare versions

Files: [CompareVersionNumbers.cs](./CompareVersionNumbers.cs), 
[CompareVersionNumbersTests.cs](./CompareVersionNumbersTests.cs)

Description: Compare two version numbers version1 and version2.
`If version1 > version2 return 1; if version1 < version2 return -1;otherwise return 0`.
You may assume that the version strings are non-empty and contain only digits and the . character.
The . character does not represent a decimal point and is used to separate number sequences.

### Steps

1. Split by `.` character both the version strings
2. Iterate both the arrays until you reach the end of one of them
    1. if v1[i] > v2[i] return 1;
    2. if v1[i] < v2[i] return -1;
    3. if you reach the end return 0
    
## Time complexity 

The time complexity is `O(n)`
_________________

## Find max number of squares




