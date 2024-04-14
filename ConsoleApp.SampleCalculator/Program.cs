// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("********* - Welcome to the sample calculator! - ********** \n");

// Show calculator options
Console.WriteLine("Calculations menu: ");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtration");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Modulus");
Console.Write("Please choose calculation: ");
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Deide which opration is needed based on selected option
int calculationResult = 0;
switch (choice)
{
    case 1:
        calculationResult = num1 + num2;
        break;
    case 2:
        calculationResult = num1 - num2;
        break;
    case 3:
        calculationResult = num1 * num2;
        break;
    case 4:
        calculationResult = num1 / num2;
        break;
    case 5:
        calculationResult = num1 % num2;
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("Invalid choice!");
        break;
}

// print output
if (choice >= 1 && choice <= 5)
{
    Console.WriteLine($"Your result calculation result is {calculationResult}");
}
else
{
    Console.WriteLine("Please try again.");
}