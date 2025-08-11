using System;

class Money
{
    protected int Whole;
    protected int Cents;

    public Money(int whole = 0, int cents = 0)
    {
        MoneySet(whole, cents);
    }

    public void MoneySet(int whole, int cents)
    {
        Whole = whole;
        Cents = cents;
        Process();
    }

    protected void Process() 
    {
        if (Cents >= 100)
        {
            Whole += Cents / 100;
            Cents = Cents % 100;
        }
        else if (Cents < 0)
        {
            int borrow = (Math.Abs(Cents) + 99) / 100;
            Whole -= borrow;
            Cents += borrow * 100;
        }

        if (Whole < 0)
        {
            Whole = 0;
            Cents = 0;
        }
    }

    public void Print()
    {
        Console.WriteLine($"{Whole} hrn {Cents:D2} kop");
    }
}

class Product : Money
{
    private string Name;

    public Product(string name, int whole, int cents) : base(whole, cents)
    {
        Name = name;
    }

    public void ReducePrice(int whole, int cents)
    {
        Whole -= whole;
        Cents -= cents;
        Process(); 
    }

    public void PrintProduct()
    {
        Console.Write($"{Name}: ");
        Print();
    }
}

class Program
{
    static void Main()
    {
        Product milk = new Product("Milk", 45, 0);
        milk.PrintProduct();

        milk.ReducePrice(10, 50);
        milk.PrintProduct();
    }
}
