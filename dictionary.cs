// // using System;
// // using System.Collections.Generic;

// // class Program
// // {
// //     static void Main()
// //     {
// //         Dictionary<int, string> students = new Dictionary<int, string>();

// //         // Adding key-value pairs
// //         students.Add(101, "Arjun");
// //         students.Add(102, "Sneha");
// //         students.Add(103, "Rahul");

// //         // Accessing
// //         Console.WriteLine("Student with ID 101: " + students[101]);

// //         // Updating
// //         students[102] = "Riya";

// //         // Looping through dictionary
// //         Console.WriteLine("All students:");
// //         foreach (KeyValuePair<int, string> kvp in students)
// //         {
// //             Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
// //         }

// //         // Check and remove
// //         if (students.ContainsKey(103))
// //         {
// //             students.Remove(103);
// //         }

// //         Console.WriteLine("Total students: " + students.Count);
// //     }
// // }
// using System;
// using System.Collections.Generic;

// namespace DictionaryDemo
// {
//     // Custom class for student
//     class Student
//     {
//         public string Name { get; set; }
//         public int Age { get; set; }

//         public void Print()
//         {
//             Console.WriteLine($"Name: {Name}, Age: {Age}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating dictionary with int key and Student object as value
//             Dictionary<int, Student> studentDict = new Dictionary<int, Student>();

//             // Adding entries
//             studentDict.Add(101, new Student { Name = "Arjun", Age = 22 });
//             studentDict[102] = new Student { Name = "Riya", Age = 21 }; // alternate add/update
//             studentDict[103] = new Student { Name = "Sneha", Age = 20 };

//             // Accessing an item
//             Console.WriteLine("Accessing student 102:");
//             studentDict[102].Print();

//             // Updating
//             studentDict[103].Age = 25;

//             // TryGetValue (safe access)
//             if (studentDict.TryGetValue(101, out Student foundStudent))
//             {
//                 Console.WriteLine("Student 101 found:");
//                 foundStudent.Print();
//             }

//             // Checking key/value exists
//             Console.WriteLine("\nContains key 104? " + studentDict.ContainsKey(104));
//             Console.WriteLine("Contains value 'Arjun'? " + studentDict.ContainsValue(new Student { Name = "Arjun", Age = 22 })); // false because different object reference

//             // Loop through dictionary
//             Console.WriteLine("\nAll Students:");
//             foreach (var entry in studentDict)
//             {
//                 Console.Write($"ID: {entry.Key}, ");
//                 entry.Value.Print();
//             }

//             // Remove
//             studentDict.Remove(102);

//             // Final count
//             Console.WriteLine($"\nTotal Students Now: {studentDict.Count}");

//             // Clear all
//             studentDict.Clear();
//             Console.WriteLine("All entries cleared.");
//         }
//     }
// }
