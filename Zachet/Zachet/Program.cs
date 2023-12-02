using System;
using System.Collections.Generic;

// Abstract class for common attributes
public abstract class Person
{
    private readonly string lastName;
    private readonly DateTime dateOfBirth;
    private readonly string faculty;

    protected Person(string lastName, DateTime dateOfBirth, string faculty)
    {
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.faculty = faculty;
    }

    public abstract void DisplayInfo();

    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - dateOfBirth.Year;

        if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
        {
            age--;
        }

        return age;
    }

    // Properties to access private fields
    public string LastName => lastName;
    public DateTime DateOfBirth => dateOfBirth;
    public string Faculty => faculty;
}

// Interface for training center employees
public interface IEmployee
{
    decimal CalculateSalary();
}

// Administrator class
public class Administrator : Person, IEmployee
{
    private readonly string laboratory;

    public Administrator(string lastName, DateTime dateOfBirth, string faculty, string laboratory)
        : base(lastName, dateOfBirth, faculty)
    {
        this.laboratory = laboratory;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Administrator: {LastName}, Faculty: {Faculty}, Laboratory: {laboratory}");
        Console.WriteLine($"Age: {CalculateAge()} years");
    }

    // IEmployee interface implementation
    public decimal CalculateSalary()
    {
       
        return 60000;
    }
}

// Student class
public class Student : Person
{
    private readonly string group;

    public Student(string lastName, DateTime dateOfBirth, string faculty, string group)
        : base(lastName, dateOfBirth, faculty)
    {
        this.group = group;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {LastName}, Faculty: {Faculty}, Group: {group}");
        Console.WriteLine($"Age: {CalculateAge()} years");
    }
}

// Teacher class
public class Teacher : Person, IEmployee
{
    private readonly string position;
    private readonly int lengthOfService;

    public Teacher(string lastName, DateTime dateOfBirth, string faculty, string position, int lengthOfService)
        : base(lastName, dateOfBirth, faculty)
    {
        this.position = position;
        this.lengthOfService = lengthOfService;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {LastName}, Faculty: {Faculty}, Position: {position}");
        Console.WriteLine($"Age: {CalculateAge()} years, Length of Service: {lengthOfService} years");
    }

    // IEmployee interface implementation
    public decimal CalculateSalary()
    {
        
        return 50000 + (lengthOfService * 2000);
    }
}

// Manager class
public class Manager : Person
{
    private readonly string position;

    public Manager(string lastName, DateTime dateOfBirth, string faculty, string position)
        : base(lastName, dateOfBirth, faculty)
    {
        this.position = position;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager: {LastName}, Faculty: {Faculty}, Position: {position}");
        Console.WriteLine($"Age: {CalculateAge()} years");
    }
}

class Program
{
    static void Main()
    {
        // Create a List<Person> to store instances of different people
        List<Person> peopleList = new List<Person>();

        // Populate the list with different people
        peopleList.Add(new Administrator("Smith", new DateTime(1990, 5, 15), "Science", "Chemistry Lab"));
        peopleList.Add(new Student("Johnson", new DateTime(1995, 8, 20), "Engineering", "A1"));
        peopleList.Add(new Teacher("Brown", new DateTime(1980, 3, 10), "Computer Science", "Professor", 10));
        peopleList.Add(new Manager("Williams", new DateTime(1975, 12, 5), "Business", "Department Head"));

        // Display information about each person in the collection
        foreach (Person person in peopleList)
        {
            person.DisplayInfo();

            // Check if the person implements the IEmployee interface and display salary if applicable
            if (person is IEmployee employee)
            {
                Console.WriteLine($"Salary: {employee.CalculateSalary():C}");
            }

            Console.WriteLine();
        }
    }
}