// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Product Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a complex program that will be used to test the functionality of the Product class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private double _price;

    public Product(string name, string productId, int quantity, double price)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotalPrice()
    {
        return _quantity * _price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
     public void SetPrice(double price)
     {
          _price = price;
     }
     public void SetName(string name)
     {
          _name = name;
     }
     public void SetProductId(string productId)
     {
          _productId = productId;
     }
     public void DisplayProductDetails()
     {
          Console.WriteLine("Product Name: " + _name);
          Console.WriteLine("Product ID: " + _productId);
          Console.WriteLine("Quantity: " + _quantity);
          Console.WriteLine("Price: $" + _price);
          Console.WriteLine("Total Price: $" + GetTotalPrice());
     }    
}
