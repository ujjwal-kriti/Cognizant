using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    // Linear Search
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];

            if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Mobile","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Bag","Fashion")
        };

        Product result1 = LinearSearch(products,103);

        Console.WriteLine("Linear Search:");

        if(result1 != null)
            Console.WriteLine(result1.ProductName);

        Product result2 = BinarySearch(products,104);

        Console.WriteLine("Binary Search:");

        if(result2 != null)
            Console.WriteLine(result2.ProductName);
    }
}


// 1. Big O Notation

// Definition:

// Big O notation is used to measure the efficiency of an algorithm by describing how its running time grows as the input size increases.

// Example
// Linear Search  → O(n)
// Binary Search  → O(log n)
// 2. Search Cases
// Best Case

// Element found at first position.

// Linear Search = O(1)
// Binary Search = O(1)
// Average Case

// Element found somewhere in the middle.

// Linear Search = O(n)
// Binary Search = O(log n)
// Worst Case

// Element found at last position or not found.

// Linear Search = O(n)
// Binary Search = O(log n)