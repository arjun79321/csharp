// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string path = @"C:\example\myfile.txt";

//         // 1. Creating and writing to file
//         using (StreamWriter writer = new StreamWriter(path))
//         {
//             writer.WriteLine("Hello, C# File Operations!");
//         }

//         // 2. Reading from file
//         string[] lines = File.ReadAllLines(path);
//         Console.WriteLine("File contents:");
//         foreach (string line in lines)
//         {
//             Console.WriteLine(line);
//         }

//         // 3. Appending data to file
//         using (StreamWriter writer = new StreamWriter(path, true))
//         {
//             writer.WriteLine("Appended text.");
//         }

//         // 4. Checking if file exists
//         if (File.Exists(path))
//         {
//             Console.WriteLine("\nFile exists, deleting now.");
//             File.Delete(path); // Delete file
//         }
//         else
//         {
//             Console.WriteLine("\nFile not found.");
//         }
//     }
// }
