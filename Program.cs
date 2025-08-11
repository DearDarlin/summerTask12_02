using System;

class MusicalInstrument
{
    protected string Name;
    protected string Description;
    protected string HistoryInfo;

    public MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        HistoryInfo = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine("A musical instrument makes a sound...");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }

    public void History()
    {
        Console.WriteLine($"History: {HistoryInfo}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string description, string history)
        : base(name, description, history) { }

    public override void Sound()
    {
        Console.WriteLine("iiiiaaa iiiiaaa");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string description, string history)
        : base(name, description, history) { }

    public override void Sound()
    {
        Console.WriteLine("boom boom boom");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description, string history)
        : base(name, description, history) { }

    public override void Sound()
    {
        Console.WriteLine("la la la");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string description, string history)
        : base(name, description, history) { }

    public override void Sound()
    {
        Console.WriteLine("liaaa liaaa");
    }
}

class Program
{
    static void Main()
    {
        Violin violin = new Violin(
            "Violin Stradivarius",
            "A bowed instrument with four strings.",
            "The violin originated in Italy in the 16th century. Stradivarius is considered the most famous master."
        );

        Trombone trombone = new Trombone(
            "Yamaha Trombone",
            "A brass wind instrument with a sliding slide.",
            "The trombone appeared in Europe in the 15th century, evolving from the medieval sacbut."
        );

        Ukulele ukulele = new Ukulele(
            "Hawaiian ukulele",
            "A small stringed instrument with four strings.",
            "The ukulele originated in Hawaii in the 19th century, borrowed from Portuguese guitars."
        );

        Cello cello = new Cello(
            "Cremona Cello",
            "A stringed instrument with a deep sound.",
            "The cello appeared in Italy in the 16th century and became the basis of orchestral music."
        );

        violin.Show();
        violin.Desc();
        violin.History();
        violin.Sound();

        Console.WriteLine();

        trombone.Show();
        trombone.Desc();
        trombone.History();
        trombone.Sound();

        Console.WriteLine();

        ukulele.Show();
        ukulele.Desc();
        ukulele.History();
        ukulele.Sound();

        Console.WriteLine();

        cello.Show();
        cello.Desc();
        cello.History();
        cello.Sound();
    }
}
