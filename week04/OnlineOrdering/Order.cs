// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Order Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a complex program that will be used to test the functionality of the Order class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }
        return totalPrice;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("Customer: " + _customer.GetName());
        Console.WriteLine("Products:");
        foreach (Product product in _products)
        {
            Console.WriteLine("- " + product.GetName() + ": $" + product.GetPrice());
        }
        Console.WriteLine("Total Price: $" + GetTotalPrice());
    }
}
