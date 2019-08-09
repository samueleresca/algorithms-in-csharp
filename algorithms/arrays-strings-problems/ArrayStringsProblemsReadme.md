# Array and strings algorithms

## Is Unique

Files: [StringIsUnique.cs](./StringIsUnique.cs), 
[StringIsUniqueTests.cs](./StringIsUniqueTests.cs)

Description: Implement an algo. to determine if a string has all unique characters. (ASCII version)

### Steps

1. If the input is longest than 128 (ASCII) return false
2. Initialize a <char, bool> dictionary
    1. if the dictionary contains the key return false;
    2. otherwise, add the char in the dictionary;
    
### Time complexity 

The time complexity is `O(n)`
_________________

## Check permutation

Files: [DetectTwoStringsArePermutations.cs](./DetectTwoStringsArePermutations.cs), 
[DetectTwoStringsArePermutationsTests.cs](./DetectTwoStringsArePermutationsTests.cs)

Description: Check if one string is the permutation of the other

### Steps

1. If the inputs have different length return false
2. Initialize a char array
3. For each character in the first string, increment the count in the corresponding cell
4. For each character in the second string, decrement the  count in the corresponding cell
    1. if the cell is different from 0 return false;
    2. otherwise continue
  
### Time complexity 

The time complexity is `O(n)`
_________________

## Palindrome string

Files: [IsPalindromeString.cs](./IsPalindromeString.cs), 
[IsPalindromeStringTests.cs](./IsPalindromeStringTests.cs)

Description: Given a string, write a function to check if it is a palindrome.
```
Input: akka
Output: true 
Input: aska
Output: false 
```

### Steps

1. Initialize a `lower` variable to 0
2. Initialize a `highest` variable to `input.Length-1`
3. While `highest` > `lower`
    1. if `input[h]` is different `input[l]` return `false`
    2. Decrement `highest` and increment `lower`
4. If the loop is ended without exiting, return `true`
  
### Time complexity 

The time complexity is `O(n)`
_________________


## Check permutation of palindrome strings

Files: [CheckPermutationPalindrome.cs](./CheckPermutationPalindrome.cs), 
[CheckPermutationPalindromeTests.cs](./CheckPermutationPalindromeTests.cs)

Description: Given a string, write a function to check if it is a permutation of a palindrome.
Notes: Strings with even length must have all even counts of chars. Strings with a odd length must have exactly one char
with odd count.
```
Input: Tact Coa
Output: true 
```

### Steps

1. Build a char frequency table by converting each char into a numeric value and incrementing the count
2. Initialize a `foundOdd` variable to false 
3. For each character 
    1. if count is divisible by 2 continue the loop
    2. if `foundOdd` is `true` return `false`;
    3. otherwise set `foundOdd` to `true`;
4. If the loop is ended without exiting, return `true`
  
### Time complexity 

The time complexity is `O(n)`
_________________


## String is unique

Files: [StringIsUnique.cs](./StringIsUnique.cs), 
[StringIsUniqueTests.cs](./StringIsUniqueTest.cs)

Description: Given a string, return `true` if contains only unique characters, otherwise `false`
with odd count.


### Steps

1. Build a char frequency table by converting each char into a numeric value and incrementing the count
2. Initialize a `foundOdd` variable to false 
3. For each character 
    1. if count is divisible by 2 continue the loop
    2. if `foundOdd` is `true` return `false`;
    3. otherwise set `foundOdd` to `true`;
4. If the loop is ended without exiting, return `true`
  
### Time complexity 

The time complexity is `O(n)`
_________________




