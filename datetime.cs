// using System;

// class Program
// {
//     static void Main()
//     {
//         DateTime now = DateTime.Now;
//         Console.WriteLine($"Now: {now}");

//         DateTime birthday = new DateTime(1998, 10, 5);
//         Console.WriteLine($"Birthday: {birthday:dddd, dd MMMM yyyy}");

//         Console.WriteLine($"Tomorrow: {now.AddDays(1)}");
//         Console.WriteLine($"Last Week: {now.AddDays(-7)}");

//         TimeSpan duration = new TimeSpan(3, 45, 0);
//         Console.WriteLine($"Manual Duration: {duration}");

//         DateTime login = new DateTime(2025, 4, 23, 9, 30, 0);
//         DateTime logout = new DateTime(2025, 4, 23, 17, 15, 0);
//         TimeSpan worked = logout - login;
//         Console.WriteLine($"Total Worked: {worked}");
//         Console.WriteLine($"Hours: {worked.Hours}, Minutes: {worked.Minutes}");

//         Console.WriteLine($"Formatted: {now:dd-MM-yyyy HH:mm}");
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         DateTime now = DateTime.Now; // Let's say now is 23rd April 2025, 14:50

//         // Custom format: dd-MM-yyyy HH:mm
//         Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm")); // 23-04-2025 14:50

//         // Long date format: "Day, Month Date, Year"
//         Console.WriteLine(now.ToLongDateString());           // Wednesday, April 23, 2025

//         // Short date format: "MM/DD/YYYY" or "DD/MM/YYYY" (based on system settings)
//         Console.WriteLine(now.ToShortDateString());          // 23/04/2025
//     }
// }
