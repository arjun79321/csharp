using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"Now: {now}");

        DateTime birthday = new DateTime(1998, 10, 5);
        Console.WriteLine($"Birthday: {birthday:dddd, dd MMMM yyyy}");

        Console.WriteLine($"Tomorrow: {now.AddDays(1)}");
        Console.WriteLine($"Last Week: {now.AddDays(-7)}");

        TimeSpan duration = new TimeSpan(3, 45, 0);
        Console.WriteLine($"Manual Duration: {duration}");

        DateTime login = new DateTime(2025, 4, 23, 9, 30, 0);
        DateTime logout = new DateTime(2025, 4, 23, 17, 15, 0);
        TimeSpan worked = logout - login;
        Console.WriteLine($"Total Worked: {worked}");
        Console.WriteLine($"Hours: {worked.Hours}, Minutes: {worked.Minutes}");

        Console.WriteLine($"Formatted: {now:dd-MM-yyyy HH:mm}");
    }
}
