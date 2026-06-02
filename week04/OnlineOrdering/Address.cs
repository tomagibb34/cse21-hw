// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Address Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a complex program that will be used to test the functionality of the Address class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
    private bool _isUSAddress;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }
     public bool IsUSAddress()
     {
          return _country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america";
     }
}
