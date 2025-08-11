using System;

class Course
{
    public string Name { get; set; }
    public int Duration { get; set; } 

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Course: {Name}, duration: {Duration} hours";
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }

    public OnlineCourse(string name, int duration, string platform)
        : base(name, duration)
    {
        Platform = platform;
    }

    public override string ToString()
    {
        return $"Online course: {Name}, duration: {Duration} hours, platform: {Platform}";
    }
}

class Program
{
    static void Main()
    {
        Course offlineCourse = new Course("C# programming", 40);
        OnlineCourse onlineCourse = new OnlineCourse("Web development", 60, "Edera");

        Console.WriteLine(offlineCourse);
        Console.WriteLine(onlineCourse);
    }
}
