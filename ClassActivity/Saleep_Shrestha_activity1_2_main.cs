/*
Name: Saleep Shrestha
Student ID: w10167735
Assignment: C# Practice Problems, Part 2
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice { PartNumber = 83, PartName = "Electric Sander", QuantityBought = 7, TotalPrice = 57.98m },
                new Invoice { PartNumber = 24, PartName = "Power Saw", QuantityBought = 18, TotalPrice = 99.99m },
                new Invoice { PartNumber = 7, PartName = "Sledgehammer", QuantityBought = 11, TotalPrice = 21.50m },
                new Invoice { PartNumber = 77, PartName = "Hammer", QuantityBought = 76, TotalPrice = 11.99m },
                new Invoice { PartNumber = 39, PartName = "Lawn Mower", QuantityBought = 3, TotalPrice = 799.50m },
                new Invoice { PartNumber = 68, PartName = "Screwdriver", QuantityBought = 106, TotalPrice = 6.99m },
                new Invoice { PartNumber = 56, PartName = "Jig saw", QuantityBought = 21, TotalPrice = 11.00m },
                new Invoice { PartNumber = 3, PartName = "Wrench", QuantityBought = 34, TotalPrice = 7.50m }
            };
            
            var sortedByName = SortByName(invoices);
            var sortedByPrice = SortByPrice(invoices);
            var filtered = FilterByMinPrice(invoices, 20.00m);
            
            
            Console.WriteLine("===== Sorted by Name =====");
            foreach (var invoice in sortedByName)
            {
                Console.WriteLine($"{invoice.PartName} - {invoice.TotalPrice:C}");
            }

            Console.WriteLine("\n===== Sorted by Price =====");
            foreach (var invoice in sortedByPrice)
            {
                Console.WriteLine($"{invoice.PartName} - {invoice.TotalPrice:C}");
            }

            Console.WriteLine("\n===== Filtered (Price > $20) =====");
            foreach (var invoice in filtered)
            {
                Console.WriteLine($"{invoice.PartName} - {invoice.TotalPrice:C}");
            }
            
        }

        public static List<Invoice> SortByName(List<Invoice> data)
        {
            return data.OrderBy(i => i.PartName).ToList();
        }

        public static List<Invoice> SortByPrice(List<Invoice> data)
        {
            return data.OrderBy(i => i.TotalPrice).ToList();
        }

        public static List<Invoice> FilterByMinPrice(List<Invoice> data, decimal minPrice)
        {
            return data.Where(i => i.TotalPrice > minPrice).ToList();
        }
    }
}