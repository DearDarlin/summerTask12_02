using System;
using System.Collections.Generic;

abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract decimal CalculateDiscount();

    public override string ToString()
    {
        return $"{Name}, price: {Price:C}";
    }
}

class Electronics : Product
{
    public Electronics(string name, decimal price) : base(name, price) { }

    public override decimal CalculateDiscount()
    {
        return Price * 0.15m;
    }
}

class Furniture : Product
{
    public Furniture(string name, decimal price) : base(name, price) { }

    public override decimal CalculateDiscount()
    {
        return Price >= 500 ? 500 : Price * 0.1m; 
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics("Phone", 20000),
            new Electronics("Notebook", 35000),
            new Furniture("Sofa", 7000),
            new Furniture("Window", 1500)
        };

        foreach (var product in products)
        {
            Console.WriteLine(product);
            Console.WriteLine($"Discount: {product.CalculateDiscount():C}");
            Console.WriteLine($"Price with discount: {product.Price - product.CalculateDiscount():C}");
            Console.WriteLine();
        }
    }
}
