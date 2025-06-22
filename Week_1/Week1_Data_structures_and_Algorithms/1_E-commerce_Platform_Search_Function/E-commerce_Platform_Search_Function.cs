using System;
using System.Diagnostics;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Category: {Category}");
    }
}

class Program
{
    public static Product LinearSearch(Product[] products, string searchName)
    {
        foreach (Product p in products)
        {
            if (p.ProductName.ToLower() == searchName.ToLower())
            {
                return p;
            }
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, string searchName)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int result = string.Compare(products[mid].ProductName, searchName, true);

            if (result == 0)
                return products[mid];
            else if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Fashion"),
            new Product(3, "Book", "Education"),
            new Product(4, "Camera", "Electronics"),
            new Product(5, "Phone", "Electronics"),
        };

        // Binary search needs sorted array
        Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("Enter product name to search:");
        string input = Console.ReadLine();

        // Linear Search with time
        Stopwatch sw1 = Stopwatch.StartNew();
        Product result1 = LinearSearch(products, input);
        sw1.Stop();

        Console.WriteLine("\nLinear Search Result:");
        if (result1 != null) result1.Display();
        else Console.WriteLine("Product not found.");
        Console.WriteLine($"Time taken: {sw1.Elapsed.TotalMilliseconds} ms");

        // Binary Search with time
        Stopwatch sw2 = Stopwatch.StartNew();
        Product result2 = BinarySearch(products, input);
        sw2.Stop();

        Console.WriteLine("\nBinary Search Result:");
        if (result2 != null) result2.Display();
        else Console.WriteLine("Product not found.");
        Console.WriteLine($"Time taken: {sw2.Elapsed.TotalMilliseconds} ms");
    }
}
