// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
 *  text - string
 *  integers - int
 *  decimal - double, float, decimal (different between precision)
 *  logical - bool
 * 
 */

string name = "Kostas";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String interpolation
Console.WriteLine("I was given the name {0}", name); // Formated string

int age = 45;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired  = false;
Console.WriteLine("Am I retired? " + isRetired);