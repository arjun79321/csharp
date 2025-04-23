// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         SortedSet<int> numbers = new SortedSet<int>();

//         numbers.Add(5);
//         numbers.Add(2);
//         numbers.Add(8);
//         numbers.Add(1);
//         numbers.Add(5); // Duplicate, won't be added

//         Console.WriteLine("SortedSet elements:");
//         foreach (var num in numbers)
//         {
//             Console.WriteLine(num);  // Output: 1, 2, 5, 8
//         }

//         Console.WriteLine("Contains 2? " + numbers.Contains(2));  // true
//         numbers.Remove(8);
//         Console.WriteLine("After removing 8:");
//         foreach (var num in numbers)
//         {
//             Console.WriteLine(num);
//         }
//     }
// }
