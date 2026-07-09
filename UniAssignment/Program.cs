// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        

        // Task 3: ArrayList of Person objects
        Console.WriteLine();
        Console.WriteLine("-- Task 3: ArrayList of Person objects --");

        ArrayList people = new ArrayList();
        people.Add(new Person("12/lamana(N)162185", "Alice"));
        people.Add(new Person("12/lamana(N)162122", "Bob"));

        foreach (Person p in people)
        {
            p.Display();
        }
    }
}

// Person class with private member data, public properties, two-argument constructor, and Display method
class Person
{
    private string _nreno;
    private string _name;

    public string Nreno { get => _nreno; set => _nreno = value; }
    public string Name { get => _name; set => _name = value; }

    public Person(string nreno, string name)
    {
        _nreno = nreno;
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Nreno: {_nreno}, Name: {_name}");
    }
}
