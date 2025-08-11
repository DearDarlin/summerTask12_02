using System;

abstract class Worker
{
    public string Name { get; set; }

    public Worker(string name)
    {
        Name = name;
    }

    public abstract void Print();
}

class President : Worker
{
    public President(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"President of the company: {Name}. Responsible for strategy and development.");
    }
}

class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Guardian: {Name}. Ensures the safety of employees and property.");
    }
}

class Manager : Worker
{
    public Manager(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}. Organizes the work of the department and monitors the implementation of tasks.");
    }
}

class Engineer : Worker
{
    public Engineer(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}. Develops technical solutions and implements new technologies.");
    }
}

class Program
{
    static void Main()
    {
        Worker[] staff = new Worker[]
        {
            new President("Darina Kovalenko"),
            new Security("Tolik Ilchenko"),
            new Manager("Sofa Xofa"),
            new Engineer("Natasha Nyloza")
        };

        foreach (Worker worker in staff)
        {
            worker.Print();
        }
    }
}
