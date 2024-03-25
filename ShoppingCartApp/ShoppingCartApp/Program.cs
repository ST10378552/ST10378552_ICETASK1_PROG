// See https://aka.ms/new-console-template for more information
using System;

namespace ShoppingCartApp
{
    // Enum defining product categories
    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    // Base class for all products
    public class Product
    {
        // Fields
        private string name;
        private double price;
        private ProductCategory category;

        // Properties
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        // Constructor
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Method to get product information
        public virtual void GetInfo()
        {
            Console.WriteLine($"Product: {name}, Price: {price}, Category: {category}");
        }
    }

    // Derived class for clothing products
    public class ClothingProduct : Product
    {
        // Fields
        private readonly string size;
        private readonly string color;

        // Properties
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        // Constructor
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        // Override method to get clothing product information
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Size: {size}, Color: {color}");
        }
    }

    // Derived class for electronics products
    public class ElectronicsProduct : Product
    {
        // Fields
        private readonly string brand;
        private readonly string model;

        // Properties
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        // Constructor
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        // Override method to get electronics product information
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }
    }

    // Class representing a shopping cart
    public class ShoppingCart
    {
        // Fields
        private Product[] products;
        private int itemCount;

        // Properties
        public Product[] Products { get { return products; } }
        public int ItemCount { get { return itemCount; } }

        // Constructor
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            products[itemCount] = product;
            itemCount++;
        }

        // Method to remove a product from the shopping cart
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] == product)
                {
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    itemCount--;
                    break;
                }
            }
        }
    }

    // Program class with Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Test code can be added here
        }
    }
}