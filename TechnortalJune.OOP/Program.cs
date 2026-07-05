// Simple console exercises: initialize, display, collect, sort and display fruit names

using System;
using System.Collections.Generic;

// 1) Define and initialize array "fruits" with five fruit names and display them
string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
Console.WriteLine("Initial fruits array:");
foreach (var f in fruits)
{
    Console.WriteLine("- " + f);
}

Console.WriteLine();

// 2) Allow user to input names into a dynamic list, ask after each input whether to continue
var userFruits = new List<string>();
while (true)
{
    Console.Write("Enter a fruit name: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("No input entered. Do you want to stop entering names? (y/n)");
        var stopAnswer = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(stopAnswer) && stopAnswer.Trim().ToLower() == "y")
            break;
        else
            continue;
    }

    userFruits.Add(input.Trim());

    Console.Write("Add another? (y/n): ");
    var answer = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(answer) || answer.Trim().ToLower() != "y")
        break;
}

// Convert to array (Larray) and sort
var Larray = userFruits.ToArray();
Array.Sort(Larray, StringComparer.OrdinalIgnoreCase);

// Display sorted names
Console.WriteLine();
Console.WriteLine("Sorted user-entered fruit names:");
if (Larray.Length == 0)
{
    Console.WriteLine("(no names entered)");
}
else
{
    foreach (var name in Larray)
    {
        Console.WriteLine("- " + name);
    }
}

Console.WriteLine();
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
