using System;

using OOP1;

class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Dolap";
        product1.UnitPrice = 750;
        product1.UnitsInStock = 5;

        Product product2 = new Product()
        {
            Id = 2,
            CategoryId = 3,
            ProductName = "Masa",
            UnitPrice = 400,
            UnitsInStock = 3
        };

        Product product3 = new Product() { Id = 3, CategoryId = 4, ProductName = "Kalem", 
            UnitPrice = 50, UnitsInStock = 15 };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
    }
}