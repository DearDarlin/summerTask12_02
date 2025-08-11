using System;

class Device
{
    protected string Name;
    protected string Description;

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("The device makes a sound...");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Shhhhhhhhhh...");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Beep-beep!");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Vroom-vroom!");
    }
}

class Steamship : Device
{
    public Steamship(string name, string description) : base(name, description) { }

    public override void Sound()
    {
        Console.WriteLine("Tu-tuuu!");
    }
}

class Program
{
    static void Main()
    {
        Kettle kettle = new Kettle("Electric kettle Philips", "Kettle with auto-off, volume 1.7 l");
        Microwave microwave = new Microwave("Samsung MW700", "Microwave oven with grill, 800W");
        Car car = new Car("Tesla Model S", "Electric car, acceleration 0-100 in 2.1 seconds");
        Steamship steamship = new Steamship("Queen Mary 2", "Ocean liner, 345 meters long");

        kettle.Show();
        kettle.Desc();
        kettle.Sound();

        Console.WriteLine();

        microwave.Show();
        microwave.Desc();
        microwave.Sound();

        Console.WriteLine();

        car.Show();
        car.Desc();
        car.Sound();

        Console.WriteLine();

        steamship.Show();
        steamship.Desc();
        steamship.Sound();
    }
}
