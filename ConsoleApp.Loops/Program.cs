// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 times

Console.WriteLine("*************** Simple For Loop ***************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop Completed!");

// Ask User how many times they wish to print hello world and print accordingly
//Console.Write("How many times should we print \"Hello World\": ");
//int userCount = Convert.ToInt32( Console.ReadLine() );

//for (int i = 0;i < userCount;i++)
//{
//    Console.WriteLine("Hello World.");
//}

Console.WriteLine("*************** Simple For Loop Completed ***************");

// While Loop
Console.WriteLine("*************** While Loop ***************");

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter += 2;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit
int sum = 0;
int num = 0;
while (num != -1)
{
    Console.Write("Please enter number to add or -1 to exit: ");
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
}
Console.WriteLine($"The total is: {sum}");

Console.WriteLine("*************** While Loop Completed ***************");

Console.WriteLine("*************** Do... While Loop ***************");
sum = 0;
num = 0;
do
{
    Console.Write("Please enter number to add or -1 to exit: ");
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"The total is: {sum}");

Console.WriteLine("*************** Do... While Loop Completed ***************");
