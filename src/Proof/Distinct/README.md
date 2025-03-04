# Distinct

Finding or creating a distinct collection of items is part and parcel of computer engineering. If you think for a moment about passwords, you want to make sure that you don't allow multiple passwords for the same login, for example. So how do you achieve distinctness? Doing something like iterating over an array and checking its contents would be terrible as it would have O(N) complexity, growing with your usercount. That would be the kiss of death for something like Facebook.

### HashSet

I'm jumping straight into the HashSet (aka Set, aka HashTable) because it's by far the most common way to de-dupe something. HashSets are unique for a couple of features:
- They do not allow duplicates
- Every values location is "hashed" in memory, which means lookup time is constant (O(1))
- They are unordered

Simply turning an array into a HashSet is enough to remove duplicates from the array. And in fact, that's exactly what you'll do in the HashSet practice problem!

[Link to HashSet](/src/Proof/Distinct/HashSet.cs)

#### Proof

Copy this code block in place of `// Copy your solution here` within `Runtime.cs` to see a HashSet sequence in action.

```C#
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
			Console.WriteLine("Original Array: " + string.Join(", ", arr));
			int[] uniqueArr = Hash.RemoveDuplicates(arr);
			Console.WriteLine("Unique Array: " + string.Join(", ", uniqueArr));
```