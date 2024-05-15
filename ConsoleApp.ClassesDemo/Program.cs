using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("************ - Classes and Objects - ************");

// define an object of type Person.
Person person; // this will be null by default

Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();
baby.GetTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2024,10,31));

person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "12312354");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
var person2IdNumber = person2.GetIdNumber();
Console.WriteLine(person2IdNumber);

var teacher = new Teacher();
teacher.LastName = "Teacher";
teacher.FirstName = "John";
teacher.DateOfBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
teacher.GenerateTeacherIdNumber();

var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teacherTaxNumber);

var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);


Student student = new();
student.LastName = "Student";
student.FirstName = "John";
student.DateOfBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();

var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

// Polygon polygon = new Polygon(); // compiler error
Rectangle rectangle = new(10,20);
var rectangleArea = rectangle.Area();
var rectanglePerimeter = rectangle.Perimeter();
rectangle.GetShapeName();
Console.WriteLine($"Rectangle area is: {rectangleArea}");
Console.WriteLine($"Rectangle perimeter is: {rectanglePerimeter}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square area is: {squareArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is: {cuboidArea}");
Console.WriteLine($"Cuboid volume is: {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");

Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(Sphere)} circumference is: {sphereCircumference}");
Console.WriteLine($"{nameof(Sphere)} volume is: {sphereVolume}");
