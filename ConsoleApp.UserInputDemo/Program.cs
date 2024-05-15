// Declare variables
using System.Globalization;
using System.Xml.Serialization;

char choice = char.MinValue;
string? firstName = string.Empty; // "";  --- ? tells the compiler that the variable may be null
string lastName = string.Empty;
int age; // A numeric variable is automatically assigned a default value of zero
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue; // '\0'
bool working = true; // Without setting a default value it will always be false

List<Person> persons = new List<Person>();

while (choice != 'E')
{
    // Prompt the user for input
    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working? (true/false): ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);

    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine());
}

// Output the result to the user
foreach (var person in persons)
{
    Console.WriteLine();
    Console.WriteLine($"Full name: {person.ToString()}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Your salary is: {person.Salary.ToString("C")}");
    Console.WriteLine($"Your gender is: {person.Gender}");
    Console.WriteLine($"You are employed: {person.IsWorking}");
    Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated Retirement year: {person.GetEstimatedRetirementDate()}");
}

