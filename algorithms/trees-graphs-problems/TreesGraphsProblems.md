# Trees and Graphs algorithms

## Binary tree traversal - In-Order

Files: [InOrderTraversal.cs](./InOrderTraversal.cs)
Description: In-order traversal means to "visit" the left branch, then the current node, then the right branch.


```
     20
    /  \
  10    30
       /  \
      25   40
      
Result: 10, 20, 25, 30, 40
```

### Steps

1. Check that the first node is not `null`, otherwise return;
2. Start recursion by calling the in-order process for the `node.left`
3. Get the value of the current node
4. Start recursion by calling the in-order process for the `node.right`

### Time complexity 

The time complexity is `O(n)`
_________________

## Binary tree traversal - Pre-Order

Files: [PreOrderTraversal.cs](./PreOrderTraversal.cs)
Description: Pre-order traversal visits the current node before its child nodes.


```
     20
    /  \
  10    30
       /  \
      25   40
      
Result: 20, 10, 30, 25, 40
```

### Steps

1. Check that the first node is not `null`, otherwise return;
2. Start recursion by calling the in-order process for the `node.left`
3. Start recursion by calling the in-order process for the `node.right`
4. Get the value of the current node

### Time complexity 

The time complexity is `O(n)`

_________________

## Binary tree traversal - Post-Order

Files: [PostOrderTraversal.cs](./PostOrderTraversal.cs)
Description: Post-order traversal visits the current node after its child nodes.


```
     20
    /  \
  10    30
       /  \
      25   40
      
Result: 10, 25, 40, 30, 20
```

### Steps

1. Check that the first node is not `null`, otherwise return;
2. Start recursion by calling the in-order process for the `node.left`
3. Start recursion by calling the in-order process for the `node.right`
4. Get the value of the current node

### Time complexity 

The time complexity is `O(n)`

_________________

## Minimal tree 

Files: [MinimalTree.cs](./MinimalTree.cs),
[MinimalTreeTests.cs](./MinimalTreeTests.cs)
Description: Given a sorted array, with unique elements, write an algo to create a BST with minimal height.


```
Result: 10, 20, 30

     20
    /  \
  10    30
```

### Steps

1. Start from cell `start = 0` and cell `end = arr.Length-1`.
2. If `end < start` return `null` otherwise continue:
3. Declare a `middle` variable which is equal to `start+end/2`
4. Declare a new node that has the `arr[middle]` value;
5. Assign the `left` attribute to the recursion of first part of the array
6. Assign the `right` attribute to the recursion of second part of the array
7. return the new node

### Time complexity 

The time complexity is `O(n log n)`

______________________

## Binary Tree Level Order Traversal

Files: [ListOfDepths.cs](./ListOfDepths.cs),
[ListOfDepthsTests.cs](./ListOfDepthsTests.cs)
Description: Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).


```
   3
   / \
  9  20
    /  \
   15   7

Result: [
          [3],
          [9,20],
          [15,7]
        ]
```

### Steps

1. Start declaring a level list of type `List<IList<int>>`
2. Define a recursive method that follows the In-Order traversal pattern
    1. If node is null `return`
    2. If the list.Count is equals to the level initialize a new list
    3. If list of level is equals to null add a new list with the node value
    4. otherwise add the node value to the corresponding level
    5. increment the level
    6. Call the recursive method for the node.left
    7. Call the recursive method for the node.right
3. Return the complete list 

### Time complexity 

The time complexity is `O(n)`

______________________

