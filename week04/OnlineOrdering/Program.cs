// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Online Order Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a simple program that will be used to test the functionality of the Online Order class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// The Online Ordering system will consist of the following classes:
// 1. Address Class - This class will represent the address of the customer.
// 2. Customer Class - This class will represent the customer of the online ordering system.
// 3. Product Class - This class will represent the products available for purchase.
// 4. Order Class - This class will represent the order placed by the customer.

using static Address;
using static Customer;
using static Product;
using static Order;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}