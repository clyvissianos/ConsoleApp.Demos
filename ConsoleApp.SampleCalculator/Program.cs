// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("********* - Welcome to the sample calculator! - ********** \n");

int choice;
do
{
    // Show calculator options
    Console.WriteLine("Calculations menu (-1 to exit): ");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtration");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Modulus");
    Console.WriteLine("6 - Fibonacci sequence");
    Console.Write("Please choose calculation: ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (choice >= 1 && choice <= 6)
    {
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
            case 6:
                for (int i = num1; i <= num2; i++)
                {
                    calculationResult += i;
                }
                break;
        }

        // print output
        Console.WriteLine($"Your calculation result is {calculationResult}");
        Console.WriteLine("Press Enter to run again");
        Console.ReadLine();
        Console.Clear();

    }
    else if (choice == -1)
    {
        continue;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
        Console.WriteLine("Press Enter to run again");
        Console.ReadLine();
        Console.Clear();
    }
 
} while (choice != -1);

Console.WriteLine("********* - Thank you for using the sample calculator! - **********");
