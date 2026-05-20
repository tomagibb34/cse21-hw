// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-19-2026

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Scripture
{
    private string reference;
    private string text;

    

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference + " - " + text);
    }
}


