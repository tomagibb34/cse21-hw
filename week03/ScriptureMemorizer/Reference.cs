// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-20-2026

// Encapsulates the responsibilities of a reference (including handling multiple verses).
// The Reference class has three private fields: book, chapter, and verse(s), which store the book name, chapter number, and verse number or numbers of the scripture reference, respectively.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reference
{
    private string _book; // Field to store the book name of the scripture reference
    private int _chapter; // Field to store the chapter number of the scripture reference
    private int _verse; // Field to store the starting verse number.
    private int _verseEnd; // Field to store the ending verse number for a scripture reference with multiple verses
    private string[] _locVerse; // Field to store the verse number(s) as a string for display purposes
    private string _verseInput; // Field to store the user input for the verse number(s)


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verseStart; // Store the starting verse number
        _verseEnd = verseEnd; // Store the ending verse number
    }
    
    // Get methods for the book, chapter, and verse(s) fields

    public string GetBook()
    {
        // Return the book name
        // Query the book name from the user input and return it
        Console.WriteLine("Please enter the book name as it appears in the scripture, example: 1 Nephi:");

        _book = Console.ReadLine();

        return _book;
    }

    public int GetChapter()
    {
        // Return the chapter number
        // Query the chapter number from the user input and return it
        Console.WriteLine("Please enter the chapter number:");
        return _chapter;
    }

    public (int, int) GetVerse()
    {
        // Return the verse number or numbers
        // If verseEnd is set return the starting verse; otherwise return single verse
        // Query the verse number(s) from the user input and return it. If the user input includes a range of verses, store the starting verse in the verse field and the ending verse in the verseEnd field, and return the starting verse number.

        Console.WriteLine("Please enter the verse number(s), separated by a hyphen if it's a range:");

        _verseInput = Console.ReadLine();
        
        if (_verseInput.Contains('-'))
        {
            _locVerse = _verseInput.Split('-');
            _verse = int.Parse(_locVerse[0].Trim()); // Store the starting verse number
            _verseEnd = int.Parse(_locVerse[1].Trim()); // Store the ending verse number
            
            return (_verse, _verseEnd); // Return the starting and ending verse numbers as a tuple
        }
        else
        {
            _verse = int.Parse(_verseInput.Trim()); // Store the single verse number
            return (_verse, 0); // Return the single verse number and 0 for the ending verse
        }
    }

    public string GetReference()
    {
        if (_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

    public string GetDisplayText()
    {
        return GetReference();
    }
}