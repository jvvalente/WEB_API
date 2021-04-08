using System;
using System.Collections.Generic;
using HW4_API.Models;

namespace HW4_API
{
    public class DataContext
    {
            public static List<Product> Inventory = new List<Product>
            {
                new ProductByQuantity(2.00, 20, "Ketchup", "Canned & Packaged Foods", 0002),
                new ProductByQuantity(2.00, 35, "Mayonnaise", "Canned & Packaged Foods", 0003),
                new ProductByQuantity(5.00, 25, "Chocolate bar", "Canned & Packaged Foods", 0004),
                new ProductByQuantity(3.50, 100, "Paper Towels", "Miscellaneous Kitchen Items", 0005),
                new ProductByQuantity(2.35, 80, "Plastic Wrap", "Miscellaneous Kitchen Items", 0006),
                new ProductByQuantity(1.50, 90, "Yougurt", "Refrigerated Foods", 0007),
                new ProductByQuantity(1.25, 150, "Bagels", "Bakery", 0008),
                new ProductByQuantity(1.00, 200, "Bread", "Bakery", 0009),
                new ProductByQuantity(3.50, 45, "Cereal", "Breakfast", 0010),
        };
    }
}
