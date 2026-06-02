// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Customer Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a complex program that will be used to test the functionality of the Customer class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
public class Customer    
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
     public void SetName(string name)
     {
          _name = name;
     }
     public void SetAddress(Address address)
     {
          _address = address;
     }
     public bool LiveInUSA;
     
}