// using System;

// class Program
// {
//     static void Main()
//     {
//         // ✅ Single-dimensional array (Declaration and initialization)
//         int[] numbers = new int[5];  // Default values will be 0
//         numbers[0] = 10;
//         numbers[1] = 20;
//         numbers[2] = 30;
//         numbers[3] = 40;
//         numbers[4] = 50;

//         Console.WriteLine("Single-dimensional array:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine($"numbers[{i}] = {numbers[i]}");
//         }

//         Console.WriteLine(); // Just for spacing

//         // ✅ Shorthand initialization
//         string[] fruits = { "Apple", "Banana", "Cherry" };
//         Console.WriteLine("Fruits array:");
//         foreach (string fruit in fruits)
//         {
//             Console.WriteLine(fruit);
//         }

//         Console.WriteLine(); // Just for spacing

//         // ✅ Multi-dimensional array (2D array)
//         int[,] grid = new int[3, 2];  // 3 rows, 2 columns
//         grid[0, 0] = 1;
//         grid[0, 1] = 2;
//         grid[1, 0] = 3;
//         grid[1, 1] = 4;
//         grid[2, 0] = 5;
//         grid[2, 1] = 6;

//         Console.WriteLine("Multi-dimensional array (grid):");
//         for (int i = 0; i < grid.GetLength(0); i++) // rows
//         {
//             for (int j = 0; j < grid.GetLength(1); j++) // columns
//             {
//                 Console.Write(grid[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }

//         Console.WriteLine(); // Just for spacing

//         // ✅ Jagged array (array of arrays)
//         int[][] jaggedArray = new int[3][];
//         jaggedArray[0] = new int[] { 1, 2, 3 };
//         jaggedArray[1] = new int[] { 4, 5 };
//         jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//         Console.WriteLine("Jagged array:");
//         for (int i = 0; i < jaggedArray.Length; i++)
//         {
//             Console.Write($"Row {i}: ");
//             for (int j = 0; j < jaggedArray[i].Length; j++)
//             {
//                 Console.Write(jaggedArray[i][j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
