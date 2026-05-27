// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-19-2026

// Encapsulates the scripture reference and text, and provides a method to display the scripture.
//Behavior that is specific to the Scripture class is that it has a constructor to initialize the reference and text
//This class does not include items or behaviors that do not pertain to it.
// The Scripture class has two private fields: reference and text, which store the scripture reference and the scripture text, respectively.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scripture
{
    
    // The Scripture class has two private fields: reference and words, which store the scripture reference and the scripture words, respectively.

    private readonly string _reference;
    private readonly string[] _words;

    // The Scripture class has a constructor that takes two parameters, reference and text, and initializes the corresponding fields with the provided values.    

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' '); // Split the scripture text into individual words and store them in an array
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return string.Join(" ", _words);
    }

    public void DisplayScripture()
    {
        if (string.IsNullOrEmpty(_reference) || string.IsNullOrEmpty(GetText()))
        {
            Console.WriteLine("No scripture reference or text to display.");
            return;
        }

        Console.WriteLine($"{_reference}: {GetText()}");
    }

}


