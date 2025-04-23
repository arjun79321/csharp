// using System;

// class Program
// {
//     static void Main()
//     {
//         // 1️⃣ Declaration
//         string name = "Arjun";
//         Console.WriteLine($"Name: {name}");

//         // 2️⃣ String Length
//         Console.WriteLine($"Length: {name.Length}");

//         // 3️⃣ ToUpper & ToLower
//         Console.WriteLine($"Upper: {name.ToUpper()}");
//         Console.WriteLine($"Lower: {name.ToLower()}");

//         // 4️⃣ Contains, StartsWith, EndsWith
//         Console.WriteLine($"Contains 'ju': {name.Contains("ju")}");
//         Console.WriteLine($"Starts with 'A': {name.StartsWith("A")}");
//         Console.WriteLine($"Ends with 'n': {name.EndsWith("n")}");

//         // 5️⃣ Substring & Replace
//         string message = "Welcome to Bangalore!";
//         Console.WriteLine($"Substring(11): {message.Substring(11)}");
//         Console.WriteLine($"Replace: {message.Replace("Bangalore", "Mumbai")}");

//         // 6️⃣ Trim
//         string messy = "   Hello World!   ";
//         Console.WriteLine($"Trimmed: '{messy.Trim()}'");

//         // 7️⃣ Split & Join
//         string colors = "Red,Green,Blue";
//         string[] colorArray = colors.Split(',');
//         Console.WriteLine("Colors:");
//         foreach (string c in colorArray)
//         {
//             Console.WriteLine(c);
//         }

//         string joinedColors = string.Join(" | ", colorArray);
//         Console.WriteLine($"Joined: {joinedColors}");

//         // 8️⃣ Comparison
//         string a = "hello";
//         string b = "HELLO";
//         Console.WriteLine($"a == b: {a == b}"); // false
//         Console.WriteLine($"Equals (ignore case): {a.Equals(b, StringComparison.OrdinalIgnoreCase)}");

//         // 9️⃣ Null or Empty
//         string emptyString = "";
//         if (string.IsNullOrEmpty(emptyString))
//         {
//             Console.WriteLine("String is empty");
//         }

//         // 🔟 Reverse a string
//         string original = "coding";
//         char[] chars = original.ToCharArray();
//         Array.Reverse(chars);
//         string reversed = new string(chars);
//         Console.WriteLine($"Reversed: {reversed}");

//         // 1️⃣1️⃣ Verbatim string
//         string path = @"C:\Users\Arjun\Projects";
//         Console.WriteLine($"Path: {path}");
//     }
// }
