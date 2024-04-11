// Declare variables
string? firstName = string.Empty; // "";  --- ? tells the compiler that the variable may be null
string lastName = string.Empty;
int age; // Anumeric variable is automatically assigned a default value of zero
int retirementAge = 65;
decimal salary;
char gender = char.MinValue; // '\0'
bool working = true; // Without setting a default value it will always be false

// Prompt the user for input
Console.Write("Please enter your first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your last name:");
lastName = Console.ReadLine();

Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true/false)");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"You are employed: {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");