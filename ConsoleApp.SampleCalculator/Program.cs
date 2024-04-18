// See https://aka.ms/new-console-template for more information

// Variable Declarations
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
do
{
    try
    {
        // Welcome Message
        Console.Clear();
        Console.WriteLine("********* - Welcome to the sample calculator! - ********** \n");
        Console.WriteLine();

        // Show calculator options
        Console.WriteLine("Calculations menu (-1 to exit): ");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Modulus");
        Console.WriteLine("6 - Fibonacci sequence");
        Console.Write("Please choose calculation: ");

        choice = Convert.ToInt32(Console.ReadLine());
 
        if (choice == -1)
        {
            break;
        }

        // Prompt for user input
        Console.WriteLine();
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();


        // Decide which operation is needed based on selected option
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
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        // print output
        Console.WriteLine($"Your calculation result is {calculationResult}");
        Console.WriteLine("Press Enter to run again");
        Console.ReadLine();
        Console.Clear();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }
    
} while (choice != -1);

Console.WriteLine("********* - Thank you for using the sample calculator! - **********");
