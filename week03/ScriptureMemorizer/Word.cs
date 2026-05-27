// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-19-2026

// Class that represents a single word in the scripture text, with properties for the word's text and whether it is hidden or visible.
// It includes methods to hide and show the word, as well as to retrieve the word's text and its hidden status. 
// The Word class encapsulates the behavior and properties of individual words in the scripture.
// This allows for easy manipulation of their visibility while keeping the implementation details hidden from other parts of the program.
// This class does not include items or behaviors that do not pertain to it.
// The Word class has two private fields: text and isHidden, which store the word's text and its hidden status, respectively.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

     public Word()
     {
     }

     public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
}

