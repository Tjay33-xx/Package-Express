using System;

// Display the welcome message to the user
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask the user for the package weight
Console.WriteLine("Please enter the package weight:");
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Check if the package is too heavy
if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return; // End the program
}

// Ask the user for the package width
Console.WriteLine("Please enter the package width:");
decimal width = Convert.ToDecimal(Console.ReadLine());

// Ask the user for the package height
Console.WriteLine("Please enter the package height:");
decimal height = Convert.ToDecimal(Console.ReadLine());

// Ask the user for the package length
Console.WriteLine("Please enter the package length:");
decimal length = Convert.ToDecimal(Console.ReadLine());

// Calculate the total dimensions of the package
decimal totalDimensions = width + height + length;

// Check if the package dimensions exceed the limit
if (totalDimensions > 50)
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return; // End the program
}

// Calculate the shipping quote
decimal quote = (width * height * length * weight) / 100;

// Display the shipping quote formatted as a dollar amount
Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

// Thank the user
Console.WriteLine("Thank you!");