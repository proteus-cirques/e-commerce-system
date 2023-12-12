// Product.cs

using System;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: ${Price:F2}");
    }
}
