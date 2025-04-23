// using System;

// class Program
// {
//     static void Main()
//     {
//         // Example 1: Using break in a loop
//         Console.WriteLine("Example 1: Using 'break' in a loop");
//         for (int i = 0; i < 10; i++)
//         {
//             if (i == 5)
//             {
//                 Console.WriteLine("Breaking the loop at i = 5");
//                 break;  // Exit the loop when i is 5
//             }
//             Console.WriteLine(i);
//         }

//         Console.WriteLine();  // Empty line for clarity

//         // Example 2: Using continue in a loop
//         Console.WriteLine("Example 2: Using 'continue' in a loop");
//         for (int i = 0; i < 10; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 // Skip even numbers
//                 continue;  // Skip the rest of the code below and go to the next iteration
//             }
//             Console.WriteLine(i);  // Print only odd numbers
//         }

//         Console.WriteLine();  // Empty line for clarity

//         // Example 3: Using return in a method
//         Console.WriteLine("Example 3: Using 'return' in a method");

//         int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//         int valueToFind = 4;

//         bool result = ContainsValue(numbers, valueToFind);
//         Console.WriteLine($"Does the array contain the number {valueToFind}? {result}");

//         valueToFind = 10;
//         result = ContainsValue(numbers, valueToFind);
//         Console.WriteLine($"Does the array contain the number {valueToFind}? {result}");
//     }

//     // Method to check if a value exists in an array
//     static bool ContainsValue(int[] numbers, int value)
//     {
//         foreach (int num in numbers)
//         {
//             if (num == value)
//             {
//                 return true;  // Return true immediately if value is found
//             }
//         }
//         return false;  // Return false if value is not found
//     }
// }
