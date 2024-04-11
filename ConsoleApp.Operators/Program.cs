// See https://aka.ms/new-console-template for more information



Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
    Math Operations and operators
 */
// Add numbers
int sum = num1 + num2;
// multiply
int product = num1 * num2;
// division
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("********************* Math Results ************************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("********************* End Math Results ************************");

/*
    Logic Operations and operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo  = num1 <= num2;
bool isNotEqual  = num1 != num2;

Console.WriteLine("********************* Logic Results ************************");
Console.WriteLine();
Console.WriteLine($"Is Greater than: {isGreaterThan}");
Console.WriteLine($"Is Less than: {isLessThan}");
Console.WriteLine($"Is Equal to: {isEqualTo}");
Console.WriteLine($"Is Greater than Or Equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less than Or Equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("********************* End Logic Results ************************");

/*
    Assignment Operations and operators
 */
Console.Write("Please insert a random value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
// int increaseValue = num1 + 5;

// num1 = num1 + 5;

Console.WriteLine("********************* Logic Results ************************");
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("********************* End Logic Results ************************");