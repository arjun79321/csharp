// using System;

// class Program
// {
//     static void Main()
//     {
//         int count = 0;

//         // While loop to print numbers from 0 to 4
//         while (count < 5)
//         {
//             Console.WriteLine(count);  // Prints the current value of count
//             count++;                   // Increments count by 1
//         }

//         // After the loop ends, you can print a message or perform other tasks
//         Console.WriteLine("Loop has completed!");
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         int choice;

//         do
//         {
//             // Display the menu
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1. Option 1");
//             Console.WriteLine("2. Option 2");
//             Console.WriteLine("3. Exit");
//             Console.Write("Enter your choice: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("You chose Option 1.");
//                     break;
//                 case 2:
//                     Console.WriteLine("You chose Option 2.");
//                     break;
//                 case 3:
//                     Console.WriteLine("Exiting...");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice, please try again.");
//                     break;
//             }

//         } while (choice != 3); // Exit the loop when user chooses 3

//         Console.WriteLine("Goodbye!");
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         string correctPassword = "password123";
//         string enteredPassword;

//         // Do-while loop to keep asking for the password
//         do
//         {
//             Console.Write("Enter your password: ");
//             enteredPassword = Console.ReadLine();
//         } while (enteredPassword != correctPassword); // Loop until the correct password is entered

//         Console.WriteLine("Password correct! Access granted.");
//     }
// }
