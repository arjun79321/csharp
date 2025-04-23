// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Create a new doubly linked list
//         LinkedList<string> names = new LinkedList<string>();

//         // Add elements
//         names.AddLast("Arjun");
//         names.AddLast("Ravi");
//         names.AddLast("Sneha");

//         Console.WriteLine("🌐 Forward Traversal:");
//         LinkedListNode<string> node = names.First;
//         while (node != null)
//         {
//             Console.WriteLine(node.Value);
//             node = node.Next;
//         }

//         Console.WriteLine("\n🔁 Backward Traversal:");
//         node = names.Last;
//         while (node != null)
//         {
//             Console.WriteLine(node.Value);
//             node = node.Previous;
//         }

//         // Insertion in the middle
//         LinkedListNode<string> raviNode = names.Find("Ravi");
//         names.AddAfter(raviNode, "Karan");

//         Console.WriteLine("\n🚀 After inserting 'Karan' after 'Ravi':");
//         foreach (string name in names)
//         {
//             Console.WriteLine(name);
//         }

//         // Remove a node
//         names.Remove("Sneha");

//         Console.WriteLine("\n🗑️ After removing 'Sneha':");
//         foreach (string name in names)
//         {
//             Console.WriteLine(name);
//         }
//     }
// }
