// See https://aka.ms/new-console-template for more information
namespace Company;

public class Employee
{
    public string Name;
    public string Surname;
    public int Age;
    public void PrintInfo()
    {
        Console.WriteLine($"Employee name {Name}, surname {Surname} and age {Age}.");
    }
}