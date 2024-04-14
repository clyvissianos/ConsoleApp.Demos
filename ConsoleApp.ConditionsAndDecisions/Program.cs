// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

//  Simple If...Else...statement - Decide to print pass or fail based on input
Console.WriteLine("*************** Simple IF Results *****************");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
} 
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("please recommend student to student affair's office");
}
Console.WriteLine("*************** Simple IF Results End *****************");


//  Complex If...Else If...statement - Decide to print letter based on grade value
Console.WriteLine("*************** Complex IF...ELSE IF Results *****************");

/*
 * A: 85 - 100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64 - else if (grade >= 50 && grade <=64)
 * F: less than 50 x
 */

if (grade < 0 || grade >100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}

Console.WriteLine("*************** Complex IF...ELSE IF Results End *****************");

//  Ternary operator - Used to assign a value to a variable based on a condition
Console.WriteLine("*************** Ternary Operator Result *****************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("*************** Ternary Operator Result End *****************");

Console.WriteLine("*************** Ternary Operator Result End *****************");

/*
    Write a program to accept an integer as the day of the week and print the appropriate
    message as outlined below.
    1 - Sunday
    2 - Monday
    3 - Tuesday
    4 - Wednesday (Hump Day!)
    5 - Thursday
    6 - Friday (TGIF!!!)
    7 - Saturday (Beach Day!!!)
 */

Console.Write("Please enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        //more code
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("(Hump Day!)");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("TGIF!!!");
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("Beach Day!!!");
        break;
    default:
        Console.WriteLine("Invalid day of the week!");
        break;
}

Console.WriteLine("*************** Ternary Operator Result End *****************");


// The rest of the application
Console.WriteLine("Thank you for using this programm");