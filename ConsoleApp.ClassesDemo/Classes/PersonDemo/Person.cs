// Define a class
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;
public partial class Person
{
    public Person() { } // Default constructor

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A";

    // Methods
    public void PrintFullName() 
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }

    public void GenerateTaxNumber()
    {
        if(string.IsNullOrEmpty( _taxNumber))
        {
            _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine($"Tax number already exists for {FirstName} {LastName}");
        } 
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
    }
}