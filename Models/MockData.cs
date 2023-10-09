using Seniorprod.Models;
using System.Xml.Serialization;



namespace Seniorprod.Models
{
    public static class MockData
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99M, Description = "Description for Product A", image="\"C:\\Users\\noahl\\OneDrive\\Pictures\\Saved Pictures\\adminlogin.png\"" },
            new Product { Id = 2, Name = "Product B", Price = 20.99M, Description = "Description for Product B" ,  image="\"C:\\Users\\noahl\\OneDrive\\Pictures\\Saved Pictures\\adminlogin.png\"" },
            // Add more products as desired
        };
    }
}
