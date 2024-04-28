Console.WriteLine("************ - Methods - ************");

// void methods - complete a task without returning a value
void PrintName()
{
    // Method code
    Console.WriteLine("Chester");
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

// methods with parameters - represent data being passed into a method
void PrintNameWithParam(string name)
{
    // Method code
    Console.WriteLine("Your name is " + name);
}

int GetYearDifferenceWithParam(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

// methods with optional parameters - parameter is not required..also has a default value 
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters
void PrintNAmeNullableParam(string? name, int? count)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}

    //if(!count.HasValue)
    //{
    //    count = 1;
    //}

    name ??= "Default Name"; // ?? checks if the value on the left is null and then assigns to it the value on the right
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}


/* Function Calls */
PrintName();
int fiveYearsAgo = GetFiveYearsAgo();
Console.WriteLine("Five years ago was " + fiveYearsAgo);

Console.Write("Enter your name: ");
string name1 = Console.ReadLine();
PrintNameWithParam(name1);

Console.Write("Enter a year: ");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParam(pastYear);
Console.WriteLine("This was " + yearsAgo + " years ago");

Console.Write("Enter number of years in the future or the past: ");
int numberOfYears = Convert.ToInt32(Console.ReadLine());

var pastYear1 = GetFutureOrPastYear();
Console.WriteLine("The year is " + pastYear1);

var pastYear2 = GetFutureOrPastYear(numberOfYears);
Console.WriteLine("The year is " + pastYear2);

PrintNAmeNullableParam(null, null);
PrintNAmeNullableParam("Chester", 5);