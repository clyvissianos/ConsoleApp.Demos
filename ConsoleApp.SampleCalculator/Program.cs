// See https://aka.ms/new-console-template for more information

// Variable Declarations
int choice = 0;
int num1, num2 = 0;
int calculationResult = 0;

// Show calculator options / Show menu
do
{
    try
    {
        PrintMenu();

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
        
        switch (choice)
        {
            case 1:
                calculationResult = AddNumbers(num1, num2);
                break;
            case 2:
                calculationResult = SubtractNumbers(num1, num2);
                break;
            case 3:
                calculationResult = Product(num1, num2);
                break;
            case 4:
                calculationResult = Quotient(num1, num2);
                break;
            case 5:
                calculationResult = Mod(num1, num2);
                break;
            case 6:
                calculationResult = Fibonacci(num1, num2);
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

// Method Definitions
int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int Product(int num1, int num2)
{
    return num1 * num2;
}

int Quotient(int num1, int num2)
{
    return num1 / num2;
}

int Mod(int num1, int num2)
{
    return num1 % num2;
}

int Fibonacci(int num1, int num2)
{
    var answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}

void PrintMenu()
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
}