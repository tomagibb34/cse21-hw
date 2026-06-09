// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-20-2026

// Encapsulates the responsibilities of a reference (including handling multiple verses).
// The Reference class has three private fields: book, chapter, and verse(s), which store the book name, chapter number, and verse number or numbers of the scripture reference, respectively.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reference
{
    private string _book; // Field to store the book name of the scripture reference
    private int _chapter; // Field to store the chapter number of the scripture reference
    private int _verse; // Field to store the starting verse number.
    private int _verseEnd; // Field to store the ending verse number for a scripture reference with multiple verses
    private string _verseInput; // Field to store the user input for the verse number(s)
    private string[] _locVerse; // Field to store the verse number(s) as a string for display purposes
    private string[] _lines; // Field to store the lines of the scriptures.txt file, which will be used to find the scripture reference and text based on the user's input. This will allow the program to store the scripture reference and text in separate strings within the Scripture class and the ScriptureMemorizer class, and to handle a scripture with multiple verses by storing the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
    private string[] _matchingScriptures; // Field to store the scripture references in the _loadedScriptures array that match the user's input for the book, chapter, and verse(s), which will be used to return the scripture reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndingVerse" if there are multiple verses. This will allow the program to store the scripture reference and text in separate strings within the Scripture class and the ScriptureMemorizer class, and to handle a scripture with multiple verses by storing the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
    private string[] _filePath; // Field to store the file path to the "lds-scriptures.txt" file, which will be used to load the scriptures from the file and to find the scripture reference and text based on the user's input for the book, chapter, and verse(s), and to return the scripture reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndingVerse" if there are multiple verses. This will allow the program to store the scripture reference and text in separate strings within the Scripture class and the ScriptureMemorizer class, and to handle a scripture with multiple verses by storing the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

    // Method to load the scriptures from the "lds-scriptures.txt" file and store them in the _lines field, which will be used to find the scripture reference and text based on the user's input for the book, chapter, and verse(s), and to return the scripture reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndingVerse" if there are multiple verses. This will allow the program to store the scripture reference and text in separate strings within the Scripture class and the ScriptureMemorizer class, and to handle a scripture with multiple verses by storing the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
    // Insure the path to the "lds-scriptures.txt" file is correct and that the file is in the correct location relative to the program, to avoid errors when loading the scriptures from the file. This will allow the program to find the scripture reference and text based on the user's input for the book, chapter, and verse(s), and to return the scripture reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndingVerse" if there are multiple verses, which will improve the user experience and help prevent errors in the program.

    public void LoadScriptures()
    {
        _filePath = ["lds-scriptures.txt"];
        _lines = File.ReadAllLines(_filePath[0]);
    }

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

        // Validate that the chapter number is a positive integer and does not contain any non-numeric characters, and return an error message if the input is invalid. This will allow the program to validate the user's input for the chapter number and to provide feedback to the user if their input is invalid, which will improve the user experience and help prevent errors in the program.

 
        while (true)
        {
            Console.WriteLine("Please enter the chapter number:");
            string chapterInput = Console.ReadLine();

            if (!int.TryParse(chapterInput, out _chapter) || chapterInput.Contains('-') || chapterInput.Contains('.') || chapterInput.Contains(',') || chapterInput.Contains(' ') || chapterInput.Any(c => !char.IsDigit(c)))
            {
                Console.WriteLine("Invalid input: non-numeric characters detected. Please enter a valid chapter number (positive integer).");
                continue;
            }
            else
            {
                break; // Exit the loop if the input is valid

            }

        }
        
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
           while (_verseInput.Count(c => c == '-') > 1)
            {
                Console.WriteLine("Invalid input: multiple hyphens detected. Please enter a valid verse number or range (e.g., '3' or '3-5'):");
                _verseInput = Console.ReadLine();
            }

            while (!int.TryParse(_verseInput.Split('-')[0].Trim(), out _) || !int.TryParse(_verseInput.Split('-')[1].Trim(), out _))
            {
                Console.WriteLine("Invalid input: non-numeric verse numbers detected. Please enter a valid verse number or range (e.g., '3' or '3-5'):");
                _verseInput = Console.ReadLine();
            }

            while (int.Parse(_verseInput.Split('-')[0].Trim()) <= 0 || int.Parse(_verseInput.Split('-')[1].Trim()) <= 0)
            {
                Console.WriteLine("Invalid input: verse numbers must be positive integers. Please enter a valid verse number or range (e.g., '3' or '3-5'):");
                _verseInput = Console.ReadLine();
            }

            while (int.Parse(_verseInput.Split('-')[0].Trim()) > int.Parse(_verseInput.Split('-')[1].Trim()))
            {
                Console.WriteLine("Invalid input: starting verse number must be less than or equal to ending verse number. Please enter a valid verse number or range (e.g., '3' or '3-5'):");
                _verseInput = Console.ReadLine();
            }

           _locVerse = _verseInput.Split('-');
            _verse = int.Parse(_locVerse[0].Trim()); // Store the starting verse number
            _verseEnd = int.Parse(_locVerse[1].Trim()); // Store the ending verse number
            
            return (_verse, _verseEnd); // Return the starting and ending verse numbers as a tuple
        }
        else
        {
            while (!int.TryParse(_verseInput.Trim(), out _))
            {
                Console.WriteLine("Invalid input: non-numeric verse number detected. Please enter a valid verse number (e.g., '3'):");
                _verseInput = Console.ReadLine();
            }
            while (int.Parse(_verseInput.Trim()) <= 0)
            {
                Console.WriteLine("Invalid input: verse number must be a positive integer. Please enter a valid verse number (e.g., '3'):");
                _verseInput = Console.ReadLine();
            }
            while (_verseInput.Contains('-'))
            {
                Console.WriteLine("Invalid input: multiple hyphens detected. Please enter a valid verse number (e.g., '3'):");
                _verseInput = Console.ReadLine();
            }

            _verse = int.Parse(_verseInput.Trim()); // Store the single verse number
            return (_verse, 0); // Return the single verse number and 0 for the ending verse
        }
    }

    public bool IsValidBook(string book)
    {
        // Check if the book name is valid by comparing it to the book names in the scriptures.txt file, and return a message indicating whether the book name is valid or not. This will allow the program to validate the user's input for the book name and to provide feedback to the user if their input is invalid, which will improve the user experience and help prevent errors in the program.
        // Query the book name from the user input and check if it is valid by comparing it to the book names in the scriptures.txt file, and return a message indicating whether the book name is valid or not.
        // Only load the scriptures from the file if they haven't been loaded already, to improve performance and avoid unnecessary file I/O operations. This will allow the program to validate the user's input for the book name and to provide feedback to the user if their input is invalid, which will improve the user experience and help prevent errors in the program.

        if (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("Invalid input: book name cannot be empty. Please enter a valid book name:");
            return false; // The book name is invalid
        }

        if (_lines == null || _lines.Length == 0)
        {
            LoadScriptures();
        }
            
        if (_lines.Any(line => line.StartsWith(book)))
        {
            return true; // The book name is valid
        }
        else
        {
            return false; // The book name is invalid
        }
    }
    
    public string[] GetReference()
    {
        // Only load the scriptures from the file if they haven't been loaded already, to improve performance and avoid unnecessary file I/O operations. This will allow the program to find the scripture reference and text based on the user's input for the book, chapter, and verse(s), and to return the scripture reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndingVerse" if there are multiple verses, which will improve the user experience and help prevent errors in the program.

       if (_lines == null || _lines.Length == 0)
        {
            LoadScriptures();
        }
       
        if (_verseEnd > 0)
        {
            // Find scriptures that contain any verse in the requested range.
            // Add in a line separator '\n' before the scripture reference to make it easier to read when there are multiple verses in the scripture reference, and to improve the user experience when displaying the scripture reference and text.

            var matchingList = new List<string>();

            foreach (var verseNumber in Enumerable.Range(_verse, _verseEnd - _verse + 1))
            {
                matchingList.AddRange(_lines.Where(line => line.StartsWith($"{_book} {_chapter}:{verseNumber} ")).Select(line => "\n" + line));
            }

            _matchingScriptures = [.. matchingList];

            return _matchingScriptures;
        }
        else
        {
            // Find scriptures that contain the single verse.
            _matchingScriptures = [.. _lines.Where(line => line.StartsWith($"{_book} {_chapter}:{_verse} "))];
            return _matchingScriptures;
        }
    }

    public string[] GetDisplayText()
    {
        return GetReference();
    }
}
