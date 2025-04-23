// int num = 100;
// long bigNum = num;  // Implicit conversion
// float price = 25.5f;
// double doublePrice = price;  // Implicit conversion

// Console.WriteLine("Big Number: " + bigNum);
// Console.WriteLine("Double Price: " + doublePrice);

// double pi = 3.14159;
// int intPi = (int)pi;  // Explicit conversion (decimal part lost)

// long bigVal = 99999;
// short shortVal = (short)bigVal;  // Might cause overflow

// Console.WriteLine("Int Pi: " + intPi);
// Console.WriteLine("Short Value: " + shortVal);
// string strNum = "123";
// int intNum = Convert.ToInt32(strNum);

// bool isAvailable = Convert.ToBoolean(1);  // 1 becomes true

// Console.WriteLine("Converted Int: " + intNum);
// Console.WriteLine("Converted Boolean: " + isAvailable);
// string priceStr = "99.99";
// double price = double.Parse(priceStr);

// Console.WriteLine("Parsed Price: " + price);
// string userInput = "123";
// bool isValid = int.TryParse(userInput, out int number);

// if (isValid)
//     Console.WriteLine("Conversion successful! Number = " + number);
// else
//     Console.WriteLine("Invalid input.");
// string userInput = "abc123";
// bool isValid = int.TryParse(userInput, out int number);

// if (isValid)
//     Console.WriteLine("Conversion successful! Number = " + number);
// else
//     Console.WriteLine("Invalid input.");
// string piStr = "3.14";
// bool isDouble = double.TryParse(piStr, out double pi);

// Console.WriteLine(isDouble ? $"Pi = {pi}" : "Invalid number");

// string boolStr = "true";
// bool isBool = bool.TryParse(boolStr, out bool flag);

// Console.WriteLine(isBool ? $"Flag = {flag}" : "Invalid boolean");
// string numberText = "123";
// int parsedNumber = int.Parse(numberText);        // Throws exception if invalid

// // Safer approach with TryParse
// bool success = int.TryParse(numberText, out int result);
// if (success)
// {
//     Console.WriteLine($"Conversion successful: {result}");
// }