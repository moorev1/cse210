using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World by me!");
        Console.WriteLine("Enter Your First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Your Last Name");
        string lastName = Console.ReadLine();
        string fullName = $"{lastName}, {firstName}, {lastName}";
        Console.WriteLine($"Your name is {fullName}");
    }
}
