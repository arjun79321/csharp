// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // 1. Basic HashSet Operations
//         HashSet<string> names = new HashSet<string>();

//         // Adding elements
//         names.Add("Arjun");
//         names.Add("Riya");
//         names.Add("Sneha");
//         names.Add("Arjun");  // Duplicate, won't be added

//         // Display all elements
//         Console.WriteLine("Names in HashSet:");
//         foreach (var name in names)
//         {
//             Console.WriteLine(name);
//         }

//         // Count the elements in the set
//         Console.WriteLine("\nTotal unique names: " + names.Count);

//         // 2. Check if an item exists in the HashSet
//         if (names.Contains("Riya"))
//         {
//             Console.WriteLine("\nRiya is in the list!");
//         }

//         // 3. Removing an element from the HashSet
//         names.Remove("Sneha");

//         Console.WriteLine("\nNames after removal of 'Sneha':");
//         foreach (var name in names)
//         {
//             Console.WriteLine(name);
//         }

//         // 4. Clear all elements from the HashSet
//         names.Clear();
//         Console.WriteLine("\nTotal names after clearing HashSet: " + names.Count);

//         // 5. Set Operations (Intersection, Union, and Difference)
//         HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4 };
//         HashSet<int> setB = new HashSet<int>() { 3, 4, 5, 6 };

//         // Intersection (common elements between two sets)
//         setA.IntersectWith(setB);
//         Console.WriteLine("\nIntersection (common elements):");
//         foreach (var item in setA)
//         {
//             Console.WriteLine(item); // 3, 4
//         }

//         // Union (all unique elements from both sets)
//         setA = new HashSet<int>() { 1, 2, 3, 4 };  // Reinitialize setA
//         setA.UnionWith(setB);
//         Console.WriteLine("\nUnion (all unique elements):");
//         foreach (var item in setA)
//         {
//             Console.WriteLine(item); // 1, 2, 3, 4, 5, 6
//         }

//         // Difference (elements in setA but not in setB)
//         setA = new HashSet<int>() { 1, 2, 3, 4 };  // Reinitialize setA
//         setA.ExceptWith(setB);
//         Console.WriteLine("\nDifference (setA - setB):");
//         foreach (var item in setA)
//         {
//             Console.WriteLine(item); // 1, 2
//         }

//         // 6. Removing Duplicates from a List using HashSet
//         List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 1, 5, 6, 5 };
//         HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

//         Console.WriteLine("\nUnique numbers (duplicates removed):");
//         foreach (var number in uniqueNumbers)
//         {
//             Console.WriteLine(number); // 1, 2, 3, 4, 5, 6
//         }
//     }
// }
